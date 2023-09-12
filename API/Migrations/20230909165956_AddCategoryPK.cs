using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryPK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Category_Category_ID",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_Category_ID",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Category_ID",
                table: "Product",
                newName: "Category_FK");
        }
    }
}
