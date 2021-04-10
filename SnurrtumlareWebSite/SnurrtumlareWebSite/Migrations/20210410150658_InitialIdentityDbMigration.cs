using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SnurrtumlareWebSite.Migrations
{
    public partial class InitialIdentityDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61ff5393-419c-48ad-887f-cdd7955a2d7d", "0469a6fa-ee91-4db5-b6d8-330c06307a23", "Admin", "ADMIN" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "8129a361-2798-4a9e-a768-b36d65993f49", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "85977c6c-b6a5-4dc1-854f-436ab35d7449", 0, "f74c4e47-afc2-4c30-8211-b5cc1ac66bd7", "send_me_your_prayers@abdi.com", true, false, null, "SEND_ME_YOUR_PRAYERS@ABDI.COM", "SEND_ME_YOUR_PRAYERS@ABDI.COM", "AQAAAAEAACcQAAAAENi6Ekv9CsvlrIIg2IYtwC4xyyg9tthAfM8oK/ayWP6Br9zAQ47lPQyyINEcZ7Am5w==", "0704563212", true, "137cc9a7-159e-47a4-a112-8603f52739ca", false, "send_me_your_prayers@abdi.com" },
                    { "1815f224-ed20-45d5-b46a-d64b0d314cf1", 0, "4649092c-d5a2-4ef5-9c96-e6075db5d290", "lind.cecilia@coldmail.com", true, false, null, "LIND.CECILIA@COLDMAIL.COM", "LIND.CECILIA@COLDMAIL.COM", "AQAAAAEAACcQAAAAEIsXT3yepfPWdbii3sBUU19Afi4f6Ui+epsd6gHHIhCNdaSYj2RUVfio2MJ2ECfCLQ==", "0736545285", true, "8c3867e9-e5a2-4871-8855-2735bbffdc97", false, "lind.cecilia@coldmail.com" },
                    { "ba4c9586-9a18-4ae9-a48e-939bbb2fe632", 0, "745598a8-cce7-4d8b-99ff-d883ab4aa1e1", "darko.petrovic@gomail.com", true, false, null, "DARKO.PETROVIC@GOMAIL.COM", "DARKO.PETROVIC@GOMAIL.COM", "AQAAAAEAACcQAAAAEI7Q//TDxFW3i1cBp7//mZaFdyPmmNDhW1L3a/3LacZ0nM5RKnB1lYtK/V5mJkJDww==", "0726547894", true, "28d1343a-8e70-4d0f-b2e6-630d468bee5f", false, "darko.petrovic@gomail.com" },
                    { "a5d96b15-709a-46db-be46-50bc86f52517", 0, "94e87987-68ad-415b-9d86-929cd77aca7b", "marljung@yahoo.it", true, false, null, "MARLJUNG@YAHOO.IT", "MARLJUNG@YAHOO.IT", "AQAAAAEAACcQAAAAEIkJ/VEVni5smkT+axr5+baxzNeY1QWb1VmYADGaVeJUfpo8ivjQYJ/3rdQadQ9ySQ==", "0726547894", true, "9cd1dbea-fc90-4953-afcb-3d5885a4dc02", false, "marljung@yahoo.it" },
                    { "6c849951-8529-4af6-b528-22ef6423776b", 0, "20ba54d8-069a-4ed8-9a65-c2bd6360d186", "robbyfire@msm.com", true, false, null, "ROBBYFIRE@MSN.COM", "ROBBYFIRE@MSN.COM", "AQAAAAEAACcQAAAAEEPblvxAH6TUcMvAsZyfuSpIqCMpfujnVipZKueHShl6E7N1LgnMgVzgZPgGgDaNUg==", "0762316497", true, "5beda90d-c949-4b36-8fb4-f553c46e8b7c", false, "robbyfire@msm.com" },
                    { "44c73f5a-bd80-439d-b961-5adc66a0a014", 0, "70f13814-2af6-4d15-bf02-7f291ae564cc", "janinamuller@ichbin.de", true, false, null, "JANINAMULLER@ICHBIN.DE", "JANINAMULLER@ICHBIN.DE", "AQAAAAEAACcQAAAAEKkVTL8vKxkcp/NU72dSq8Bv3PkZoXuqJWQa+AjY0HAUBZlhSZSLtM6TzbdV/DyHAA==", "0726547894", true, "1b4ed832-bd73-4329-8b71-7915b3ce1866", false, "janinamuller@ichbin.de" },
                    { "bb839b54-be8d-4511-aacc-86e4702a2a4e", 0, "b041ad6b-fb94-4ac2-b402-1d40f999b1e8", "pedro_velasquez@hotmail.se", true, false, null, "PEDRO_VELASQUEZ@HOTMAIL.SE", "PEDRO_VELASQUEZ@HOTMAIL.SE", "AQAAAAEAACcQAAAAED5A21aC+DFI97LghmY7R0qTIbUdR1ItJFRR1hUbezgrGgAvIOsEaDwGdH2UNr3iDQ==", "0736974121", true, "deb85ad5-8986-4fef-9755-ffddad14d98e", false, "pedro_velasquez@hotmail.se" },
                    { "842069dc-8e11-4ace-bc2f-2c7ece81ad26", 0, "9e61de3d-8597-491d-8a69-90db35b53e90", "amiina_asghar_84@yahoo.se", true, false, null, "AMIINA_ASGHAR_84@YAHOO.SE", "AMIINA_ASGHAR_84@YAHOO.SE", "AQAAAAEAACcQAAAAEBuvZMXEe4aKnoPTCiNphffCUImCkal11piNdOZ//dQA8V5YwvwhKMCnu5/s6lBA9g==", "0704563289", true, "52cb0577-a520-4f2e-b596-e0e6a20b1ae2", false, "amiina_asghar_84@yahoo.se" },
                    { "e381a86a-b160-4607-96c1-d0add3c6b5da", 0, "8c9711ef-1a4f-42b4-9f7d-2b226e071fd9", "unouno@saltsill.com", true, false, null, "UNOUNO@SALTSILL.COM", "UNOUNO@SALTSILL.COM", "AQAAAAEAACcQAAAAEMq2S8btCh5rWlUXaDKew06hbmleOc1j8np151SogaOK0TC2eo1kilwzkSHY2JJGpA==", "0704563289", true, "42a92536-d903-488d-bc68-fa0e168fa493", false, "unouno@saltsill.com" },
                    { "953e18dd-1743-4f33-b43a-ea9c8ec7f5ec", 0, "40da8512-78fc-428e-bbd7-9032d99a62f2", "juha_1337@suomisoundi.fi", true, false, null, "JUHA_1337@SUOMISOUNDI.FI", "JUHA_1337@SUOMISOUNDI.FI", "AQAAAAEAACcQAAAAEIvk4OTm3VwnDzranQJZgctgq2mB/DfkRSFDKXOcmyV5c7wsBiKVdFe8SCpp9KvjDg==", "0768521498", true, "168b21b3-6da1-431e-8b93-9451b58e9d37", false, "juha_1337@suomisoundi.fi" },
                    { "a6cf9af6-d62e-4ed5-8f4f-031431f8cf09", 0, "874558d2-3f24-47dc-abab-06c238d0a669", "anderspersson52@irra.se", true, false, null, "ANDERSPERSSON52@IRRA.SE", "ANDERSPERSSON52@IRRA.SE", "AQAAAAEAACcQAAAAEHvnPo00PM4EyxmO55vGhGTlu6l6ThVdKJiBlqof9JZU1vvtykw2OWEAP1X8yQdHqg==", "0768521498", true, "68581108-e101-4071-a013-7b6e0792b2f7", false, "anderspersson52@irra.se" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "61ff5393-419c-48ad-887f-cdd7955a2d7d", "85977c6c-b6a5-4dc1-854f-436ab35d7449" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "1815f224-ed20-45d5-b46a-d64b0d314cf1" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "ba4c9586-9a18-4ae9-a48e-939bbb2fe632" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "a5d96b15-709a-46db-be46-50bc86f52517" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "6c849951-8529-4af6-b528-22ef6423776b" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "44c73f5a-bd80-439d-b961-5adc66a0a014" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "bb839b54-be8d-4511-aacc-86e4702a2a4e" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "842069dc-8e11-4ace-bc2f-2c7ece81ad26" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "e381a86a-b160-4607-96c1-d0add3c6b5da" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "953e18dd-1743-4f33-b43a-ea9c8ec7f5ec" },
                    { "d0910552-ea45-4b50-a574-11bba92d95c4", "a6cf9af6-d62e-4ed5-8f4f-031431f8cf09" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
