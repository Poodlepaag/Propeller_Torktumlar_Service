using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.ViewModels;
using SnurrtumlareWebSite.Views.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace SnurrtumlareWebSite.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ApplicationDbContext applicationDbContext;

        public AdministrationController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDbContext applicationDbContext)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.applicationDbContext = applicationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Administration");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }


            return View(model);
        }

        [HttpGet]
        public IActionResult ListRoles(string searchString, int? page)
        {

            var roles = roleManager.Roles.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                roles = roles.Where(s => s.Name.ToLower().Contains(searchString.ToLower())).ToList();
            }


            int pageSize = 5;
            int pageNumber = (page ?? 1);

            ViewBag.OnePageOfRoles = roles.ToPagedList(pageNumber, pageSize);

            return View();



            //var roles = roleManager.Roles;
            //return View(roles);
        }


        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id: {id} cannot be found";

                return View("NotFoundAdministration");
            }

            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            //var users = userManager.Users;
            var data = userManager.GetUsersInRoleAsync(role.Name).Result;

            foreach (var item in data)
            {
                var user = userManager.Users.FirstOrDefault(u => u.Id == item.Id);

                if (item.Id == user.Id)
                //if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(item.UserName);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleViewModel model)
        {
            var role = await roleManager.FindByIdAsync(model.Id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id: {model.Id} cannot be found";
                return View("NotFoundAdministration");
            }
            else
            {
                role.Name = model.RoleName;

                // Update the Role using UpdateAsync
                var result = await roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
        }


        [HttpPost]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id: {id} cannot be found";
                return View("NotFoundAdministration");
            }
            else
            {
                var result = await roleManager.DeleteAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("ListRoles");
            }
        }


        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id: {roleId} cannot be found";

                return View("NotFoundAdministration");
            }

            var model = new List<UserRoleViewModel>();


            var AspNetUsers = userManager.Users.ToList();
            //var usersInRole = userManager.GetUsersInRoleAsync(role.Name).Result.ToList();
            var AspNetRoles = applicationDbContext.UserRoles.ToList();


            foreach (var user in AspNetUsers)
            {
                var userRoleViewModel = new UserRoleViewModel { UserId = user.Id, UserName = user.UserName };

                var isInRole = (from Roles in AspNetRoles
                                join User in AspNetUsers on Roles.UserId equals User.Id
                                where Roles.UserId == user.Id && Roles.RoleId == roleId
                                select User).Any();

                if (!isInRole)
                {
                    userRoleViewModel.IsSelected = false;
                }
                else
                {
                    userRoleViewModel.IsSelected = true;
                }

                model.Add(userRoleViewModel);
            }

            return View(model);
        }



        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }

        [HttpGet]
        public IActionResult ListUsers(string searchString, int? page)
        {

            var users = userManager.Users.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => s.NormalizedEmail.Contains(searchString.ToUpper())).ToList();
            }

            int pageSize = 5;
            int pageNumber = (page ?? 1);

            ViewBag.OnePageOfUsers = users.ToPagedList(pageNumber, pageSize);

            return View();

            //var users = userManager.Users;
            //return View(users);
        }

    }
}
