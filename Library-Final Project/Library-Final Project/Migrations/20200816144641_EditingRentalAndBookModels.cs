using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_Final_Project.Migrations
{
    public partial class EditingRentalAndBookModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Rentals_RentalId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_RentalId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "RentalId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Rentals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_BookId",
                table: "Rentals",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Books_BookId",
                table: "Rentals",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Books_BookId",
                table: "Rentals");

            migrationBuilder.DropIndex(
                name: "IX_Rentals_BookId",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Rentals");

            migrationBuilder.AddColumn<int>(
                name: "RentalId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_RentalId",
                table: "Books",
                column: "RentalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Rentals_RentalId",
                table: "Books",
                column: "RentalId",
                principalTable: "Rentals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
