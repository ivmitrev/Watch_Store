using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WatchStoreApi.Migrations
{
    /// <inheritdoc />
    public partial class RolexAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 3, 1, "Oyster, 40 mm, Oystersteel", "/Images/Rolex/gmt-master2.png", "Rolex GMT-MASTER II", 21650m, 4 },
                    { 4, 1, "Oyster, 40 mm, Everose gold", "/Images/Rolex/daydate40.png", "Rolex Day-Date 40", 87300m, 3 },
                    { 5, 1, "Oyster, 40 mm, white gold", "/Images/Rolex/daytonaCosmo.png", "Rolex Cosmograph Daytona", 89500m, 1 },
                    { 6, 1, "Oyster, 41 mm, Oystersteel", "/Images/Rolex/perpetual41.png", "Rolex Oyster Perpetual 41", 12850m, 4 },
                    { 7, 1, "Oyster, 42 mm, RLX titanium", "/Images/Rolex/yachmaster42.png", "Rolex YachtMaster 42", 28450m, 10 },
                    { 8, 1, "Oyster, 43 mm, Oystersteel and yellow gold", "/Images/Rolex/seadweller43.png", "Rolex Sea-Dweller", 38000m, 6 },
                    { 9, 1, "Oyster, 44 mm, yellow gold", "/Images/Rolex/deepsea44.png", "Rolex Deepsea", 109600m, 1 },
                    { 10, 1, "Oyster, 40 mm, Oystersteel", "/Images/Rolex/airking40.png", "Rolex Air-King", 14950m, 11 },
                    { 11, 1, "Oyster, 36 mm, Oystersteel and yellow gold", "/Images/Rolex/explorer36.png", "Rolex Explorer 36", 24800m, 18 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
