using Microsoft.EntityFrameworkCore.Migrations;

namespace SnurrtumlareWebSite.Migrations
{
    public partial class newMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "1815f224-ed20-45d5-b46a-d64b0d314cf1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "44c73f5a-bd80-439d-b961-5adc66a0a014" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "6c849951-8529-4af6-b528-22ef6423776b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "842069dc-8e11-4ace-bc2f-2c7ece81ad26" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "61ff5393-419c-48ad-887f-cdd7955a2d7d", "85977c6c-b6a5-4dc1-854f-436ab35d7449" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "953e18dd-1743-4f33-b43a-ea9c8ec7f5ec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "a5d96b15-709a-46db-be46-50bc86f52517" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "a6cf9af6-d62e-4ed5-8f4f-031431f8cf09" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "ba4c9586-9a18-4ae9-a48e-939bbb2fe632" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "bb839b54-be8d-4511-aacc-86e4702a2a4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0910552-ea45-4b50-a574-11bba92d95c4", "e381a86a-b160-4607-96c1-d0add3c6b5da" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61ff5393-419c-48ad-887f-cdd7955a2d7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0910552-ea45-4b50-a574-11bba92d95c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1815f224-ed20-45d5-b46a-d64b0d314cf1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44c73f5a-bd80-439d-b961-5adc66a0a014");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c849951-8529-4af6-b528-22ef6423776b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "842069dc-8e11-4ace-bc2f-2c7ece81ad26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85977c6c-b6a5-4dc1-854f-436ab35d7449");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "953e18dd-1743-4f33-b43a-ea9c8ec7f5ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5d96b15-709a-46db-be46-50bc86f52517");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6cf9af6-d62e-4ed5-8f4f-031431f8cf09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba4c9586-9a18-4ae9-a48e-939bbb2fe632");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb839b54-be8d-4511-aacc-86e4702a2a4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e381a86a-b160-4607-96c1-d0add3c6b5da");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09d9e200-1c12-4580-90bc-5a084187cbbf", "ce8d2618-a72c-4883-98ad-75fb20e06ac2", "Admin", "ADMIN" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "4b0f5479-9a47-458e-8178-97473ef79826", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d868bfd3-3848-4876-91d3-4e6231c7b540", 0, "6582cc27-5198-4b7a-b5d0-61354377c5f0", "send_me_your_prayers@abdi.com", true, false, null, "SEND_ME_YOUR_PRAYERS@ABDI.COM", "SEND_ME_YOUR_PRAYERS@ABDI.COM", "AQAAAAEAACcQAAAAEC94UtArUQjvtTzZCMATAg3Gvyw9/qYMdeFG9IBXrTsPyIEKIT1fh/ZLokUAtDxwFg==", "0704563212", true, "414e6642-dd63-481a-907f-dc75331228e6", false, "send_me_your_prayers@abdi.com" },
                    { "02c0ac9c-c9de-4fb9-8fc7-6a01438c6e4c", 0, "0aea341b-b176-4e13-96b0-35d72ff7040b", "lind.cecilia@coldmail.com", true, false, null, "LIND.CECILIA@COLDMAIL.COM", "LIND.CECILIA@COLDMAIL.COM", "AQAAAAEAACcQAAAAEI+7UVhG96s2bAS07XscHeOARn6yEbBU7j4PnAtGO5L1sMzVDzi6gR+BL2LFs4UIDQ==", "0736545285", true, "c22a2b9f-566e-4ea2-b807-8af5bb6f904d", false, "lind.cecilia@coldmail.com" },
                    { "86da85e2-cb80-4813-b7cb-9e0549e24fa5", 0, "ba2397ae-cfab-47ed-a680-2abb87dbca9f", "darko.petrovic@gomail.com", true, false, null, "DARKO.PETROVIC@GOMAIL.COM", "DARKO.PETROVIC@GOMAIL.COM", "AQAAAAEAACcQAAAAEGheJi9Ilx3AtLv6xEKD2C/qqNRbbBD0eBhfALkCdbwWzLxAx/aYmB5Y22I4UIDJDA==", "0726547894", true, "0a8353f6-66e2-4739-899e-7558cee81347", false, "darko.petrovic@gomail.com" },
                    { "ae8ae8a4-7374-4266-b0cb-bfec59994381", 0, "560d4256-d4a7-42b3-97f6-04c87895992b", "marljung@yahoo.it", true, false, null, "MARLJUNG@YAHOO.IT", "MARLJUNG@YAHOO.IT", "AQAAAAEAACcQAAAAENzc6j/8lisikDf9AVujKXl2gJZVzF5YxkIWyvOwcZMdNAP/abaqeh5gpsqGk224UQ==", "0726547894", true, "8b0644e8-3ad7-4cbc-a001-a2e8a332f224", false, "marljung@yahoo.it" },
                    { "f8814924-3cd7-4115-82bb-978fc3de301e", 0, "1dc800d6-63ec-4549-b427-fc44fbe41ef7", "robbyfire@msm.com", true, false, null, "ROBBYFIRE@MSN.COM", "ROBBYFIRE@MSN.COM", "AQAAAAEAACcQAAAAEJbtAmclHBsZpweqgtwa89UmwBTWo+PHrKDmEITJY2W9fF3Yb0159+QoxB1JgUUJhQ==", "0762316497", true, "d58922dc-ee85-4934-afde-d2f5e3ac3255", false, "robbyfire@msm.com" },
                    { "aa576395-28ef-418c-8d45-9f46011ca694", 0, "f0ba9f7b-72c3-46de-ab6d-cf8750a31f10", "janinamuller@ichbin.de", true, false, null, "JANINAMULLER@ICHBIN.DE", "JANINAMULLER@ICHBIN.DE", "AQAAAAEAACcQAAAAEH7GsVCdjCX5qQCC8dZcsB0+jj+GFrMZ390nF4S6CLuJsAirWBXwVoXkPxo8GzfuiQ==", "0726547894", true, "157c86ce-6f90-4430-b2ba-201c3103b8bc", false, "janinamuller@ichbin.de" },
                    { "8b1edaa6-a5c8-49a5-8928-2194f5a488a3", 0, "ec2bb96e-e9bb-407a-88cf-bd6c74b46750", "pedro_velasquez@hotmail.se", true, false, null, "PEDRO_VELASQUEZ@HOTMAIL.SE", "PEDRO_VELASQUEZ@HOTMAIL.SE", "AQAAAAEAACcQAAAAEDRzKOuJJsBWcYiZKptcO+coYQVeLxsZ4DymKHHWcDQ49d5FZxsxtZgKZbMT6ZcPzQ==", "0736974121", true, "4b4ef217-df5e-4b47-b13d-e151ec9cde8d", false, "pedro_velasquez@hotmail.se" },
                    { "dc7a6cd6-1058-4a04-8223-e14237063382", 0, "c4eb1e8a-5df3-4312-92d9-e65f27238be7", "amiina_asghar_84@yahoo.se", true, false, null, "AMIINA_ASGHAR_84@YAHOO.SE", "AMIINA_ASGHAR_84@YAHOO.SE", "AQAAAAEAACcQAAAAEFv5L0IvMX3j4wH8kCFHqCYE5e3Iii6+XS9Rvck7MfzDcDVErxqThpjSLP7h0WC0tQ==", "0704563289", true, "253afd52-f97e-482a-a27f-126b84f43d13", false, "amiina_asghar_84@yahoo.se" },
                    { "ba21cf47-9005-4584-9716-fe4199f4dca0", 0, "695f3266-3ce4-4da7-9b3a-1ada42df8662", "unouno@saltsill.com", true, false, null, "UNOUNO@SALTSILL.COM", "UNOUNO@SALTSILL.COM", "AQAAAAEAACcQAAAAEP7eLXrRN/OJVkKyK7OkbE627PNRSZ6ioNSBRPs0p8W4ckzk8AtU/blX5czZN525JQ==", "0704563289", true, "b0459779-bee2-4706-a236-cd85f33ca907", false, "unouno@saltsill.com" },
                    { "6a904d99-0e82-4978-ae18-88baf5a69a84", 0, "6d86b644-684b-47ac-b2b6-ff142eb211df", "juha_1337@suomisoundi.fi", true, false, null, "JUHA_1337@SUOMISOUNDI.FI", "JUHA_1337@SUOMISOUNDI.FI", "AQAAAAEAACcQAAAAEHK+TTJNqtL70OJJWugxfP2Nbzbg1Q47xstgPPPmdcUGZK0Qf5N24IiZXWDgErkQVw==", "0768521498", true, "abc1c7f6-e1cf-46e7-9f18-db341b7b0233", false, "juha_1337@suomisoundi.fi" },
                    { "dbb4261d-cddd-47a3-8cc7-021fdba2c4e6", 0, "c0f2b79e-af27-421f-ad86-b8d49c50333e", "anderspersson52@irra.se", true, false, null, "ANDERSPERSSON52@IRRA.SE", "ANDERSPERSSON52@IRRA.SE", "AQAAAAEAACcQAAAAECPjfa/jxZGY94DiO2UuFOhs05GHahtnm5WUiE4d2L5N9PNPNVmLpyRSc8Rdw7Ubbw==", "0768521498", true, "2d459c2e-1219-4a36-b4ec-d03687301ca1", false, "anderspersson52@irra.se" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "09d9e200-1c12-4580-90bc-5a084187cbbf", "d868bfd3-3848-4876-91d3-4e6231c7b540" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "02c0ac9c-c9de-4fb9-8fc7-6a01438c6e4c" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "86da85e2-cb80-4813-b7cb-9e0549e24fa5" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "ae8ae8a4-7374-4266-b0cb-bfec59994381" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "f8814924-3cd7-4115-82bb-978fc3de301e" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "aa576395-28ef-418c-8d45-9f46011ca694" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "8b1edaa6-a5c8-49a5-8928-2194f5a488a3" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "dc7a6cd6-1058-4a04-8223-e14237063382" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "ba21cf47-9005-4584-9716-fe4199f4dca0" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "6a904d99-0e82-4978-ae18-88baf5a69a84" },
                    { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "dbb4261d-cddd-47a3-8cc7-021fdba2c4e6" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "02c0ac9c-c9de-4fb9-8fc7-6a01438c6e4c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "6a904d99-0e82-4978-ae18-88baf5a69a84" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "86da85e2-cb80-4813-b7cb-9e0549e24fa5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "8b1edaa6-a5c8-49a5-8928-2194f5a488a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "aa576395-28ef-418c-8d45-9f46011ca694" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "ae8ae8a4-7374-4266-b0cb-bfec59994381" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "ba21cf47-9005-4584-9716-fe4199f4dca0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09d9e200-1c12-4580-90bc-5a084187cbbf", "d868bfd3-3848-4876-91d3-4e6231c7b540" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "dbb4261d-cddd-47a3-8cc7-021fdba2c4e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "dc7a6cd6-1058-4a04-8223-e14237063382" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab21345d-f0d6-483a-bbee-6219d4bf9b36", "f8814924-3cd7-4115-82bb-978fc3de301e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09d9e200-1c12-4580-90bc-5a084187cbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab21345d-f0d6-483a-bbee-6219d4bf9b36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02c0ac9c-c9de-4fb9-8fc7-6a01438c6e4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a904d99-0e82-4978-ae18-88baf5a69a84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86da85e2-cb80-4813-b7cb-9e0549e24fa5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b1edaa6-a5c8-49a5-8928-2194f5a488a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa576395-28ef-418c-8d45-9f46011ca694");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae8ae8a4-7374-4266-b0cb-bfec59994381");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba21cf47-9005-4584-9716-fe4199f4dca0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d868bfd3-3848-4876-91d3-4e6231c7b540");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbb4261d-cddd-47a3-8cc7-021fdba2c4e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc7a6cd6-1058-4a04-8223-e14237063382");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8814924-3cd7-4115-82bb-978fc3de301e");

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
        }
    }
}
