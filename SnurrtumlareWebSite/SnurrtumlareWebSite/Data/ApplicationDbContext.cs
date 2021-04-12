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

            string ADMIN_ROLE_Id = Guid.NewGuid().ToString();
            string ADMIN_ROLE_ConcurrencyStamp = Guid.NewGuid().ToString();

            string USER_ROLE_Id = Guid.NewGuid().ToString();
            string USER_ROLE_ConcurrencyStamp = Guid.NewGuid().ToString();


            string ADMIN_Id = Guid.NewGuid().ToString();
            string ADMIN_ConcurrencyStamp = Guid.NewGuid().ToString();

            //string USER_Id1 = Guid.NewGuid().ToString();
            //string USER_ConcurrencyStamp1 = Guid.NewGuid().ToString();

            string USER_Id2 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp2 = Guid.NewGuid().ToString();

            string USER_Id3 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp3 = Guid.NewGuid().ToString();

            string USER_Id4 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp4 = Guid.NewGuid().ToString();

            string USER_Id5 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp5 = Guid.NewGuid().ToString();

            string USER_Id6 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp6 = Guid.NewGuid().ToString();

            string USER_Id7 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp7 = Guid.NewGuid().ToString();

            string USER_Id8 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp8 = Guid.NewGuid().ToString();

            string USER_Id9 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp9 = Guid.NewGuid().ToString();

            string USER_Id10 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp10 = Guid.NewGuid().ToString();

            string USER_Id11 = Guid.NewGuid().ToString();
            string USER_ConcurrencyStamp11 = Guid.NewGuid().ToString();




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


            //create Admin Abdi
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




            //create User Cecilia
            var appUser2 = new IdentityUser
            {
                Id = USER_Id2,
                Email = "lind.cecilia@coldmail.com",
                NormalizedEmail = "LIND.CECILIA@COLDMAIL.COM",
                EmailConfirmed = true,
                UserName = "lind.cecilia@coldmail.com",
                NormalizedUserName = "LIND.CECILIA@COLDMAIL.COM",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp2,
                PhoneNumber = "0736545285",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser2 = new PasswordHasher<IdentityUser>();
            appUser2.PasswordHash = phUser2.HashPassword(appUser2, "Password1!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser2);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id2
            });



            //create User Darko
            var appUser3 = new IdentityUser
            {
                Id = USER_Id3,
                Email = "darko.petrovic@gomail.com",
                NormalizedEmail = "DARKO.PETROVIC@GOMAIL.COM",
                EmailConfirmed = true,
                UserName = "darko.petrovic@gomail.com",
                NormalizedUserName = "DARKO.PETROVIC@GOMAIL.COM",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp3,
                PhoneNumber = "0726547894",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser3 = new PasswordHasher<IdentityUser>();
            appUser3.PasswordHash = phUser3.HashPassword(appUser3, "Password1!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser3);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id3
            });



            //create User Märta
            var appUser4 = new IdentityUser
            {
                Id = USER_Id4,
                Email = "marljung@yahoo.it",
                NormalizedEmail = "MARLJUNG@YAHOO.IT",
                EmailConfirmed = true,
                UserName = "marljung@yahoo.it",
                NormalizedUserName = "MARLJUNG@YAHOO.IT",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp4,
                PhoneNumber = "0726547894",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser4 = new PasswordHasher<IdentityUser>();
            appUser4.PasswordHash = phUser4.HashPassword(appUser4, "Password1!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser4);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id4
            });



            //create User Robert
            var appUser5 = new IdentityUser
            {
                Id = USER_Id5,
                Email = "robbyfire@msm.com",
                NormalizedEmail = "ROBBYFIRE@MSN.COM",
                EmailConfirmed = true,
                UserName = "robbyfire@msm.com",
                NormalizedUserName = "ROBBYFIRE@MSN.COM",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp5,
                PhoneNumber = "0762316497",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser5 = new PasswordHasher<IdentityUser>();
            appUser5.PasswordHash = phUser5.HashPassword(appUser5, "Password1!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser5);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id5
            });




            //create User Janina
            var appUser6 = new IdentityUser
            {
                Id = USER_Id6,
                Email = "janinamuller@ichbin.de",
                NormalizedEmail = "JANINAMULLER@ICHBIN.DE",
                EmailConfirmed = true,
                UserName = "janinamuller@ichbin.de",
                NormalizedUserName = "JANINAMULLER@ICHBIN.DE",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp6,
                PhoneNumber = "0726547894",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser6 = new PasswordHasher<IdentityUser>();
            appUser6.PasswordHash = phUser6.HashPassword(appUser6, "Password1!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser6);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id6
            });




            //create User Pedro
            var appUser7 = new IdentityUser
            {
                Id = USER_Id7,
                Email = "pedro_velasquez@hotmail.se",
                NormalizedEmail = "PEDRO_VELASQUEZ@HOTMAIL.SE",
                EmailConfirmed = true,
                UserName = "pedro_velasquez@hotmail.se",
                NormalizedUserName = "PEDRO_VELASQUEZ@HOTMAIL.SE",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp7,
                PhoneNumber = "0736974121",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser7 = new PasswordHasher<IdentityUser>();
            appUser7.PasswordHash = phUser7.HashPassword(appUser7, "Password1!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser7);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id7
            });



            //create User Amina
            var appUser8 = new IdentityUser
            {
                Id = USER_Id8,
                Email = "amiina_asghar_84@yahoo.se",
                NormalizedEmail = "AMIINA_ASGHAR_84@YAHOO.SE",
                EmailConfirmed = true,
                UserName = "amiina_asghar_84@yahoo.se",
                NormalizedUserName = "AMIINA_ASGHAR_84@YAHOO.SE",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp8,
                PhoneNumber = "0704563289",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser8 = new PasswordHasher<IdentityUser>();
            appUser8.PasswordHash = phUser8.HashPassword(appUser8, "Password1!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser8);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id8
            });


            //create User Uno
            var appUser9 = new IdentityUser
            {
                Id = USER_Id9,
                Email = "unouno@saltsill.com",
                NormalizedEmail = "UNOUNO@SALTSILL.COM",
                EmailConfirmed = true,
                UserName = "unouno@saltsill.com",
                NormalizedUserName = "UNOUNO@SALTSILL.COM",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp9,
                PhoneNumber = "0704563289",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser9 = new PasswordHasher<IdentityUser>();
            appUser9.PasswordHash = phUser9.HashPassword(appUser9, "Password1!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser9);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id9
            });


            //create User Juha
            var appUser10 = new IdentityUser
            {
                Id = USER_Id10,
                Email = "juha_1337@suomisoundi.fi",
                NormalizedEmail = "JUHA_1337@SUOMISOUNDI.FI",
                EmailConfirmed = true,
                UserName = "juha_1337@suomisoundi.fi",
                NormalizedUserName = "JUHA_1337@SUOMISOUNDI.FI",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp10,
                PhoneNumber = "0768521498",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser10 = new PasswordHasher<IdentityUser>();
            appUser10.PasswordHash = phUser10.HashPassword(appUser10, "JuhaÄrGrejt1337!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser10);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id10
            });



            //create User Aners
            var appUser11 = new IdentityUser
            {
                Id = USER_Id11,
                Email = "anderspersson52@irra.se",
                NormalizedEmail = "ANDERSPERSSON52@IRRA.SE",
                EmailConfirmed = true,
                UserName = "anderspersson52@irra.se",
                NormalizedUserName = "ANDERSPERSSON52@IRRA.SE",
                //PasswordHash
                //SecurityStamp
                ConcurrencyStamp = USER_ConcurrencyStamp11,
                PhoneNumber = "0768521498",
                PhoneNumberConfirmed = true
            };

            //set User password
            PasswordHasher<IdentityUser> phUser11 = new PasswordHasher<IdentityUser>();
            appUser11.PasswordHash = phUser11.HashPassword(appUser11, "Password1!");

            //seed user
            modelBuilder.Entity<IdentityUser>().HasData(appUser11);

            //set user role to user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = USER_ROLE_Id,
                UserId = USER_Id11
            });

        }
    }
}
