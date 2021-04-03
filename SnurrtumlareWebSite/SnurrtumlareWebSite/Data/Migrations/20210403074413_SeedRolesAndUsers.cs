using Microsoft.EntityFrameworkCore.Migrations;

namespace SnurrtumlareWebSite.Data.Migrations
{
    public partial class SeedRolesAndUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "84bf6f44-a2c0-4e44-8bc5-d01268960a65", "d439d508-359d-4295-993e-c41976a864fb", "Admin", "ADMIN" },
                    { "daf5e0fa-d3ea-4953-b5f8-630250fc399e", "c4599e2b-63c4-4f99-8afd-e92339cc923c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "cf5ca05a-0dbc-4225-918d-db98befefe43", 0, "34bf5fc3-e694-455d-8856-d95a74a86b7a", "send_me_your_prayers@abdi.com", true, false, null, "SEND_ME_YOUR_PRAYERS@ABDI.COM", "SEND_ME_YOUR_PRAYERS@ABDI.COM", "AQAAAAEAACcQAAAAEAGD6MmhFZKQxSiqPmB6/XnRYRE4XsTzjRmXUvsnKerS1S8Pq61/maF4EAEWzOOn7w==", "0704563212", true, "e9f415d6-100a-4df0-8c53-e4db264f5f82", false, "send_me_your_prayers@abdi.com" },
                    { "7c1f5a50-d16e-417c-b0bd-ebdc05e88d93", 0, "daadde3a-7e79-47ef-963b-f95ef0f02f69", "juha_1337@suomisoundi.fi", true, false, null, "JUHA_1337@SUOMISOUNDI.FI", "JUHA_1337@SUOMISOUNDI.FI", "AQAAAAEAACcQAAAAEGn+9d44e89uIlbSm20fP4jvhQAAORkSmdJIIDHj8ZIuJHrwNp7l4UYZWQsLNoOyBQ==", "0768521498", true, "8c955b05-3c89-4f57-96d2-2fb7b47ef100", false, "juha_1337@suomisoundi.fi" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "84bf6f44-a2c0-4e44-8bc5-d01268960a65", "cf5ca05a-0dbc-4225-918d-db98befefe43" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "daf5e0fa-d3ea-4953-b5f8-630250fc399e", "7c1f5a50-d16e-417c-b0bd-ebdc05e88d93" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "daf5e0fa-d3ea-4953-b5f8-630250fc399e", "7c1f5a50-d16e-417c-b0bd-ebdc05e88d93" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84bf6f44-a2c0-4e44-8bc5-d01268960a65", "cf5ca05a-0dbc-4225-918d-db98befefe43" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84bf6f44-a2c0-4e44-8bc5-d01268960a65");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf5e0fa-d3ea-4953-b5f8-630250fc399e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c1f5a50-d16e-417c-b0bd-ebdc05e88d93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf5ca05a-0dbc-4225-918d-db98befefe43");
        }
    }
}
