using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.ViewModels;
using SnurrtumlareWebSite.Views.Administration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
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


            var users = userManager.Users;
            var userInRole = userManager.GetUsersInRoleAsync(role.Name).Result;
            var d = roleManager.Roles.ToList();

            //var userRoles = userManager.GetRolesAsync();
            var x = applicationDbContext.UserRoles.ToList();
            //_context.Products.Where(p => p.Category == category).ToList();


            foreach (var user in users)
            {
                var c = x.Where(u => u.UserId == user.Id).ToString();

                if (user.Id == c)
                {

                }
            }

            foreach (var item in userInRole)
            {
                foreach (var user in users)
                {
                    var c = x.Where(u => u.UserId == user.Id);

                    if (user.Id == item.Id)
                    {
                        var userRoleViewModel = new UserRoleViewModel { UserId = user.Id, UserName = user.UserName };

                        if (user.Id != item.Id)
                        {
                            userRoleViewModel.IsSelected = false;
                        }
                        else
                        {
                            userRoleViewModel.IsSelected = true;
                        }

                        model.Add(userRoleViewModel);
                        //DETTA FUNKAR NU SKA BARA ABDI LÄGGAS TILL TOM
                        // KOLLA ÄVEN DEN ANDRA VARIANTEN OM MAN ANVÄNDER BREAK;
                    }
                    else
                    {
                        //var userRoleViewModel = new UserRoleViewModel { UserId = user.Id, UserName = user.UserName };

                        //if (user.Id != item.Id)
                        //{
                        //    userRoleViewModel.IsSelected = true;
                        //}
                        //else
                        //{
                        //    break;
                        //    //userRoleViewModel.IsSelected = false;
                        //}

                        //model.Add(userRoleViewModel);
                    }

                    //var userRoleViewModel = new UserRoleViewModel { UserId = user.Id, UserName = user.UserName };

                    //if (user.Id != item.Id)
                    //{
                    //    userRoleViewModel.IsSelected = true;
                    //}
                    //else
                    //{
                    //    break;
                    //    //userRoleViewModel.IsSelected = false;
                    //}

                    //model.Add(userRoleViewModel);
                }

                //var userRoleViewModel = new UserRoleViewModel { UserId = user.Id, UserName = user.UserName };
            }

            //foreach (var user in users)
            //{
            //    //var data = userManager.GetUsersInRoleAsync(role.Name).Result;

            //    //var userToFind = userManager.GetUsersInRoleAsync(role.Name).Result;
            //    //var userToFind = userManager.Users.FirstOrDefault(u => u.Id == user.Id);
            //    //var userToFind = userManager.Users.Include(u => u.Id).FirstOrDefault(u => u.Id == user.Id);
            //    foreach (var item in userInRole)
            //    {
            //        if (user.Id != item.Id)
            //        {
            //            var userRoleViewModel = new UserRoleViewModel { UserId = user.Id, UserName = user.UserName };
            //            //var toFind = await userManager.IsInRoleAsync(user, role.Name);

            //            if (user.Id != item.Id)
            //            {
            //                userRoleViewModel.IsSelected = false;
            //            }
            //            else
            //            {
            //                userRoleViewModel.IsSelected = true;
            //            }


            //            model.Add(userRoleViewModel);
            //        }
            //    }
            //    //if (await userManager.IsInRoleAsync(user, role.Name))
            //    //    userRoleViewModel.IsSelected = true;
            //    //else
            //    //    userRoleViewModel.IsSelected = false;

            //    //userRoleViewModel.IsSelected = (await userManager.IsInRoleAsync(user, role.Name)) ? true : false;


            //    //model.Add(userRoleViewModel);
            //}

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
        public IActionResult ListUsers()
        {
            var users = userManager.Users;
            return View(users);
        }

    }
}
