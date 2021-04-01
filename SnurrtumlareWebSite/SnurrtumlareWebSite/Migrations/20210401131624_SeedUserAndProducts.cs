using Microsoft.EntityFrameworkCore.Migrations;

namespace SnurrtumlareWebSite.Migrations
{
    public partial class SeedUserAndProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_OrderId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AmountInStock", "Category", "ImageLink", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 25, "Keps", "/assets/pictures/Kepsar/Prop1.png", "Kepsarnas keps", "Propellerkeps Deluxe", 189m },
                    { 2, 10, "Keps", "/assets/pictures/Kepsar/Prop10.png", "Keps med guldskärm", "Propellerkeps Premium", 179m },
                    { 3, 5, "Torktumlare", "/assets/pictures/Torktumlare/Tork1.png", "Instegsmodell bland torktumlare", "Torktumlare X3", 4990m },
                    { 4, 2, "Torktumlare", "/assets/pictures/Torktumlare/Tork10.png", "Premium Torktumlare med det lilla extra", "Torktumlare XT55", 7990m },
                    { 5, 5, "Keps", "/assets/pictures/Kepsar/Prop11.png", "Propellerkepsen för den som testar gränser", "Propellerkeps Crazy", 149m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "City", "Email", "FirstName", "LastName", "Phone", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Himlastråket 666", "Himmelriket", "send_me_your_prayers@abdi.com", "Abdi", "Benådsson", "0704563212", "12345" },
                    { 2, "Sillstigen 12", "Karlstad", "lind.cecilia@coldmail.com", "Cecilia", "Lind", "0736545285", "65225" },
                    { 3, "Gnejsvägen 45", "Hammarstrand", "darko.petrovic@gomail.com", "Darko", "Petrovic", "0726547894", "84070" },
                    { 4, "Nobelvägen 62", "Malmö", "marljung@yahoo.it", "Märta", "Ljunquist", "040979797", "21215" },
                    { 5, "Smultronstråket 11", "Farsta", "robbyfire@msm.com", "Robert", "Fayer", "0762316497", "12323" },
                    { 6, "Forskningsvägen 2", "Umeå", "janinamuller@ichbin.de", "Janina", "Müller", "0702026978", "90638" },
                    { 7, "Gesslegatan 70", "Halmstad", "pedro_velasquez@hotmail.se", "Pedro", "Velasquez", "0736974121", "30261" },
                    { 8, "Polartorget 2", "Åtvidaberg", "amiina_asghar_84@yahoo.se", "Amina", "Asghar", "0704563289", "59791" },
                    { 9, "Marsipanvägen 45", "Växjö", "unouno@saltsill.com", "Uno", "Svenningsson", "0729875214", "35258" },
                    { 10, "Trälgatan 102", "Örebro", "juha_1337@suomisoundi.fi", "Juha", "Määki", "0768521498", "70510" },
                    { 11, "Rödmålavägen 7", "Lund", "anderspersson52@irra.se", "Anders", "Persson", "0701238545", "22242" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_OrderId",
                table: "Products",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Orders_OrderId",
                table: "Products",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
