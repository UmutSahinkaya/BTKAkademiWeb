using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BTKAkademiWeb.MVC.Migrations
{
    /// <inheritdoc />
    public partial class updateProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ShowCase",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ShowCase",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ShowCase",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ShowCase",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ShowCase",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ShowCase",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ShowCase",
                value: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                column: "ShowCase",
                value: false);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ImageUrl", "Price", "ProductName", "ShowCase", "Summary" },
                values: new object[,]
                {
                    { 8, 1, "/images/8.jpg", 1145m, "Xp-Pen", true, "" },
                    { 9, 2, "/images/9.jpg", 4445m, "Galaxy FE", true, "" },
                    { 10, 1, "/images/10.jpg", 545m, "Hp Mouse", true, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "ShowCase",
                table: "Products");
        }
    }
}
