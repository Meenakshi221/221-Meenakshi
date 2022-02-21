using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineProductStore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductCode = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductCode);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    LoginId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.LoginId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderNumber = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginId = table.Column<string>(nullable: true),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderAmount = table.Column<int>(nullable: false),
                    Active = table.Column<int>(nullable: false),
                    UserLoginId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderNumber);
                    table.ForeignKey(
                        name: "FK_Order_User_UserLoginId",
                        column: x => x.UserLoginId,
                        principalTable: "User",
                        principalColumn: "LoginId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<int>(nullable: false),
                    ProductAmount = table.Column<int>(nullable: false),
                    ProductCode = table.Column<string>(nullable: true),
                    OrderNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OrderDetailsID);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderNumber",
                        column: x => x.OrderNumber,
                        principalTable: "Order",
                        principalColumn: "OrderNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductCode",
                        column: x => x.ProductCode,
                        principalTable: "Product",
                        principalColumn: "ProductCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserLoginId",
                table: "Order",
                column: "UserLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderNumber",
                table: "OrderDetail",
                column: "OrderNumber");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductCode",
                table: "OrderDetail",
                column: "ProductCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
