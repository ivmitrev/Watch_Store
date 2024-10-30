using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WatchStoreApi.Migrations
{
    /// <inheritdoc />
    public partial class addedHublot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 12, 2, "Big Bang, 44 mm, Polished Yellow Ceramic, Rubber Strap", "/Images/Hublot/hublot12.png", "Unico Yellow Magic 44", 61600m, 4 },
                    { 13, 2, "Classic Fusion, 42 mm, Polished Black Ceramic, Rubber Strap", "/Images/Hublot/hublot1.png", "Chronograph Black Magic 42", 25600m, 8 },
                    { 14, 2, "Big Band, 44 mm, Stainless Steel, Black Rubber Strap", "/Images/Hublot/hublot2.png", "Original Steel Ceramic 44", 30400m, 2 },
                    { 15, 2, "Big Bang, 42 mm, Microblasted Black Ceramic, Black Fabric and Black Ceramic Buckle", "/Images/Hublot/hublot3.png", "Unico Ice Bang 42", 50000m, 11 },
                    { 16, 2, "Tourbillon, 42 mm, Satin-finished and Polished Titanium, Sapphire with Anti-reflective Treatment", "/Images/Hublot/hublot4.png", "Tourbillon Sorai 42", 230000m, 1 },
                    { 17, 2, "Big Bang, 38 mm, Microblasted Black Ceramic, Black ceramic and Black Titane Deployant Buckle", "/Images/Hublot/hublot5.png", "Integrated Time Only Titanium 38", 27200m, 4 },
                    { 18, 2, "Big Bang, 44 mm, Polished and Satin-finished Stainless Steel, Blue Straps", "/Images/Hublot/hublot6.png", "Big Bang Steel Blue 44", 28200m, 3 },
                    { 19, 2, "Big Bang, 44 mm, Polished and Satin-finished 18k 5N Gold, Blue Straps", "/Images/Hublot/hublot7.png", "Big Bang Gold Blue 44", 75200m, 7 },
                    { 20, 2, "Racing Grey Chronograph Titanium, 42 mm, Satin-finished Titanium, Gray Straps", "/Images/Hublot/hublot8.png", "Classic Fusion 42", 23400m, 11 },
                    { 21, 2, "Original Yellow Gold, 38 mm, Black Straps", "/Images/Hublot/hublot9.png", "Classic Fusion Gold 38", 44600m, 2 },
                    { 22, 2, "Chronograph Titanium Green, 42 mm, Satin-finished Titanium, Green Straps", "/Images/Hublot/hublot10.png", "Classic Fusion Green 42", 22000m, 8 },
                    { 23, 2, "Square Bang Gold, 42 mm, Black Straps", "/Images/Hublot/hublot11.png", "Unico Ceramic Loon 42", 66000m, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);
        }
    }
}
