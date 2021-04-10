using Microsoft.EntityFrameworkCore.Migrations;

namespace SnurrtumlareWebSite.Migrations.SnurrtumlareDb
{
    public partial class InitialSnurrtumlareDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TotalOrderCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderRow",
                columns: table => new
                {
                    OrderRowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderRow", x => x.OrderRowId);
                    table.ForeignKey(
                        name: "FK_OrderRow_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderRow_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "ImageLink", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, "Keps", "/assets/pictures/Kepsar/Prop1.png", "Kepsarnas keps", "Propellerkeps Deluxe", 189m },
                    { 2, "Keps", "/assets/pictures/Kepsar/Prop10.png", "Keps med guldskärm", "Propellerkeps Premium", 179m },
                    { 3, "Torktumlare", "/assets/pictures/Torktumlare/Tork1.png", "Instegsmodell bland torktumlare", "Torktumlare X3", 4990m },
                    { 4, "Torktumlare", "/assets/pictures/Torktumlare/Tork10.png", "Premium Torktumlare med det lilla extra", "Torktumlare XT55", 7990m },
                    { 5, "Keps", "/assets/pictures/Kepsar/Prop11.png", "Propellerkepsen för den som testar gränser", "Propellerkeps Crazy", 149m }
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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "IsDelivered", "TotalOrderCost", "UserId" },
                values: new object[] { 123456, false, 999m, 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "IsDelivered", "TotalOrderCost", "UserId" },
                values: new object[] { 234567, true, 4995m, 2 });

            migrationBuilder.InsertData(
                table: "OrderRow",
                columns: new[] { "OrderRowId", "OrderId", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 12, 123456, 1, 1 },
                    { 13, 123456, 2, 2 },
                    { 14, 234567, 3, 1 },
                    { 15, 234567, 4, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderRow_OrderId",
                table: "OrderRow",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRow_ProductId",
                table: "OrderRow",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderRow");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
