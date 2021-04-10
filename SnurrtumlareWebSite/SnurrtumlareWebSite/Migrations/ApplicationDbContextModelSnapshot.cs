﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SnurrtumlareWebSite.Data;

namespace SnurrtumlareWebSite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "61ff5393-419c-48ad-887f-cdd7955a2d7d",
                            ConcurrencyStamp = "0469a6fa-ee91-4db5-b6d8-330c06307a23",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d0910552-ea45-4b50-a574-11bba92d95c4",
                            ConcurrencyStamp = "8129a361-2798-4a9e-a768-b36d65993f49",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "85977c6c-b6a5-4dc1-854f-436ab35d7449",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f74c4e47-afc2-4c30-8211-b5cc1ac66bd7",
                            Email = "send_me_your_prayers@abdi.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SEND_ME_YOUR_PRAYERS@ABDI.COM",
                            NormalizedUserName = "SEND_ME_YOUR_PRAYERS@ABDI.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENi6Ekv9CsvlrIIg2IYtwC4xyyg9tthAfM8oK/ayWP6Br9zAQ47lPQyyINEcZ7Am5w==",
                            PhoneNumber = "0704563212",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "137cc9a7-159e-47a4-a112-8603f52739ca",
                            TwoFactorEnabled = false,
                            UserName = "send_me_your_prayers@abdi.com"
                        },
                        new
                        {
                            Id = "1815f224-ed20-45d5-b46a-d64b0d314cf1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4649092c-d5a2-4ef5-9c96-e6075db5d290",
                            Email = "lind.cecilia@coldmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "LIND.CECILIA@COLDMAIL.COM",
                            NormalizedUserName = "LIND.CECILIA@COLDMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEIsXT3yepfPWdbii3sBUU19Afi4f6Ui+epsd6gHHIhCNdaSYj2RUVfio2MJ2ECfCLQ==",
                            PhoneNumber = "0736545285",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "8c3867e9-e5a2-4871-8855-2735bbffdc97",
                            TwoFactorEnabled = false,
                            UserName = "lind.cecilia@coldmail.com"
                        },
                        new
                        {
                            Id = "ba4c9586-9a18-4ae9-a48e-939bbb2fe632",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "745598a8-cce7-4d8b-99ff-d883ab4aa1e1",
                            Email = "darko.petrovic@gomail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DARKO.PETROVIC@GOMAIL.COM",
                            NormalizedUserName = "DARKO.PETROVIC@GOMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEI7Q//TDxFW3i1cBp7//mZaFdyPmmNDhW1L3a/3LacZ0nM5RKnB1lYtK/V5mJkJDww==",
                            PhoneNumber = "0726547894",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "28d1343a-8e70-4d0f-b2e6-630d468bee5f",
                            TwoFactorEnabled = false,
                            UserName = "darko.petrovic@gomail.com"
                        },
                        new
                        {
                            Id = "a5d96b15-709a-46db-be46-50bc86f52517",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "94e87987-68ad-415b-9d86-929cd77aca7b",
                            Email = "marljung@yahoo.it",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MARLJUNG@YAHOO.IT",
                            NormalizedUserName = "MARLJUNG@YAHOO.IT",
                            PasswordHash = "AQAAAAEAACcQAAAAEIkJ/VEVni5smkT+axr5+baxzNeY1QWb1VmYADGaVeJUfpo8ivjQYJ/3rdQadQ9ySQ==",
                            PhoneNumber = "0726547894",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "9cd1dbea-fc90-4953-afcb-3d5885a4dc02",
                            TwoFactorEnabled = false,
                            UserName = "marljung@yahoo.it"
                        },
                        new
                        {
                            Id = "6c849951-8529-4af6-b528-22ef6423776b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "20ba54d8-069a-4ed8-9a65-c2bd6360d186",
                            Email = "robbyfire@msm.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ROBBYFIRE@MSN.COM",
                            NormalizedUserName = "ROBBYFIRE@MSN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEPblvxAH6TUcMvAsZyfuSpIqCMpfujnVipZKueHShl6E7N1LgnMgVzgZPgGgDaNUg==",
                            PhoneNumber = "0762316497",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "5beda90d-c949-4b36-8fb4-f553c46e8b7c",
                            TwoFactorEnabled = false,
                            UserName = "robbyfire@msm.com"
                        },
                        new
                        {
                            Id = "44c73f5a-bd80-439d-b961-5adc66a0a014",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "70f13814-2af6-4d15-bf02-7f291ae564cc",
                            Email = "janinamuller@ichbin.de",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JANINAMULLER@ICHBIN.DE",
                            NormalizedUserName = "JANINAMULLER@ICHBIN.DE",
                            PasswordHash = "AQAAAAEAACcQAAAAEKkVTL8vKxkcp/NU72dSq8Bv3PkZoXuqJWQa+AjY0HAUBZlhSZSLtM6TzbdV/DyHAA==",
                            PhoneNumber = "0726547894",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "1b4ed832-bd73-4329-8b71-7915b3ce1866",
                            TwoFactorEnabled = false,
                            UserName = "janinamuller@ichbin.de"
                        },
                        new
                        {
                            Id = "bb839b54-be8d-4511-aacc-86e4702a2a4e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b041ad6b-fb94-4ac2-b402-1d40f999b1e8",
                            Email = "pedro_velasquez@hotmail.se",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "PEDRO_VELASQUEZ@HOTMAIL.SE",
                            NormalizedUserName = "PEDRO_VELASQUEZ@HOTMAIL.SE",
                            PasswordHash = "AQAAAAEAACcQAAAAED5A21aC+DFI97LghmY7R0qTIbUdR1ItJFRR1hUbezgrGgAvIOsEaDwGdH2UNr3iDQ==",
                            PhoneNumber = "0736974121",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "deb85ad5-8986-4fef-9755-ffddad14d98e",
                            TwoFactorEnabled = false,
                            UserName = "pedro_velasquez@hotmail.se"
                        },
                        new
                        {
                            Id = "842069dc-8e11-4ace-bc2f-2c7ece81ad26",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9e61de3d-8597-491d-8a69-90db35b53e90",
                            Email = "amiina_asghar_84@yahoo.se",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "AMIINA_ASGHAR_84@YAHOO.SE",
                            NormalizedUserName = "AMIINA_ASGHAR_84@YAHOO.SE",
                            PasswordHash = "AQAAAAEAACcQAAAAEBuvZMXEe4aKnoPTCiNphffCUImCkal11piNdOZ//dQA8V5YwvwhKMCnu5/s6lBA9g==",
                            PhoneNumber = "0704563289",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "52cb0577-a520-4f2e-b596-e0e6a20b1ae2",
                            TwoFactorEnabled = false,
                            UserName = "amiina_asghar_84@yahoo.se"
                        },
                        new
                        {
                            Id = "e381a86a-b160-4607-96c1-d0add3c6b5da",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8c9711ef-1a4f-42b4-9f7d-2b226e071fd9",
                            Email = "unouno@saltsill.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "UNOUNO@SALTSILL.COM",
                            NormalizedUserName = "UNOUNO@SALTSILL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMq2S8btCh5rWlUXaDKew06hbmleOc1j8np151SogaOK0TC2eo1kilwzkSHY2JJGpA==",
                            PhoneNumber = "0704563289",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "42a92536-d903-488d-bc68-fa0e168fa493",
                            TwoFactorEnabled = false,
                            UserName = "unouno@saltsill.com"
                        },
                        new
                        {
                            Id = "953e18dd-1743-4f33-b43a-ea9c8ec7f5ec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "40da8512-78fc-428e-bbd7-9032d99a62f2",
                            Email = "juha_1337@suomisoundi.fi",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JUHA_1337@SUOMISOUNDI.FI",
                            NormalizedUserName = "JUHA_1337@SUOMISOUNDI.FI",
                            PasswordHash = "AQAAAAEAACcQAAAAEIvk4OTm3VwnDzranQJZgctgq2mB/DfkRSFDKXOcmyV5c7wsBiKVdFe8SCpp9KvjDg==",
                            PhoneNumber = "0768521498",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "168b21b3-6da1-431e-8b93-9451b58e9d37",
                            TwoFactorEnabled = false,
                            UserName = "juha_1337@suomisoundi.fi"
                        },
                        new
                        {
                            Id = "a6cf9af6-d62e-4ed5-8f4f-031431f8cf09",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "874558d2-3f24-47dc-abab-06c238d0a669",
                            Email = "anderspersson52@irra.se",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANDERSPERSSON52@IRRA.SE",
                            NormalizedUserName = "ANDERSPERSSON52@IRRA.SE",
                            PasswordHash = "AQAAAAEAACcQAAAAEHvnPo00PM4EyxmO55vGhGTlu6l6ThVdKJiBlqof9JZU1vvtykw2OWEAP1X8yQdHqg==",
                            PhoneNumber = "0768521498",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "68581108-e101-4071-a013-7b6e0792b2f7",
                            TwoFactorEnabled = false,
                            UserName = "anderspersson52@irra.se"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "85977c6c-b6a5-4dc1-854f-436ab35d7449",
                            RoleId = "61ff5393-419c-48ad-887f-cdd7955a2d7d"
                        },
                        new
                        {
                            UserId = "1815f224-ed20-45d5-b46a-d64b0d314cf1",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        },
                        new
                        {
                            UserId = "ba4c9586-9a18-4ae9-a48e-939bbb2fe632",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        },
                        new
                        {
                            UserId = "a5d96b15-709a-46db-be46-50bc86f52517",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        },
                        new
                        {
                            UserId = "6c849951-8529-4af6-b528-22ef6423776b",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        },
                        new
                        {
                            UserId = "44c73f5a-bd80-439d-b961-5adc66a0a014",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        },
                        new
                        {
                            UserId = "bb839b54-be8d-4511-aacc-86e4702a2a4e",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        },
                        new
                        {
                            UserId = "842069dc-8e11-4ace-bc2f-2c7ece81ad26",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        },
                        new
                        {
                            UserId = "e381a86a-b160-4607-96c1-d0add3c6b5da",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        },
                        new
                        {
                            UserId = "953e18dd-1743-4f33-b43a-ea9c8ec7f5ec",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        },
                        new
                        {
                            UserId = "a6cf9af6-d62e-4ed5-8f4f-031431f8cf09",
                            RoleId = "d0910552-ea45-4b50-a574-11bba92d95c4"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
