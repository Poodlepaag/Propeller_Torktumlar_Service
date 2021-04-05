using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnurrtumlareWebSite.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<IdentityRole> Identities { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            string ADMIN_Id = Guid.NewGuid().ToString();
            //string ADMIN_Id = "1";
            string ADMIN_ConcurrencyStamp = Guid.NewGuid().ToString();

            string USER_Id = Guid.NewGuid().ToString();
            //string USER_Id = "2";
            string USER_ConcurrencyStamp = Guid.NewGuid().ToString();

            string ADMIN_ROLE_Id = Guid.NewGuid().ToString();
            //string ADMIN_ROLE_Id = "1";
            string ADMIN_ROLE_ConcurrencyStamp = Guid.NewGuid().ToString();

            string USER_ROLE_Id = Guid.NewGuid().ToString();
            //string USER_ROLE_Id = "2";
            string USER_ROLE_ConcurrencyStamp = Guid.NewGuid().ToString();

            //seed Admin role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = ADMIN_ROLE_Id,
                ConcurrencyStamp = ADMIN_ROLE_ConcurrencyStamp
            });

            //seed User role
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
                Id = USER_ROLE_Id,
                ConcurrencyStamp = USER_ROLE_ConcurrencyStamp
            });


            //create Admin
            var appAdmin = new IdentityUser
            {
                Id = ADMIN_Id,
                Email = "send_me_your_prayers@abdi.com",
                NormalizedEmail = "SEND_ME_YOUR_PRAYERS@ABDI.COM",
                EmailConfirmed = true,
                UserName = "send_me_your_prayers@abdi.com",
                NormalizedUserName = "SEND_ME_YOUR_PRAYERS@ABDI.COM",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = ADMIN_ConcurrencyStamp,
                PhoneNumber = "0704563212",
                PhoneNumberConfirmed = true
            };

            //create User
            var appUser = new IdentityUser
            {
                Id = USER_Id,
                Email = "juha_1337@suomisoundi.fi",
                NormalizedEmail = "JUHA_1337@SUOMISOUNDI.FI",
                EmailConfirmed = true,
                UserName = "juha_1337@suomisoundi.fi",
                NormalizedUserName = "JUHA_1337@SUOMISOUNDI.FI",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp,
                PhoneNumber = "0768521498",
                PhoneNumberConfirmed = true
            };



            //set Admin password
            PasswordHasher<IdentityUser> phAdmin = new PasswordHasher<IdentityUser>();
            appAdmin.PasswordHash = phAdmin.HashPassword(appAdmin, "GudÄrGrejt1337!");

            //seed Admin
            modelBuilder.Entity<IdentityUser>().HasData(appAdmin);

            //set Admin role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ADMIN_ROLE_Id,
                UserId = ADMIN_Id
            });



            //set User password
            PasswordHasher<IdentityUser> phUser = new PasswordHasher<IdentityUser>();
            appUser.PasswordHash = phUser.HashPassword(appUser, "JuhaÄrGrejt1337!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id
            });

        }
    }
}
