using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAkademiECommerce.Discount.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActice",
                table: "Coupons",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Coupons",
                newName: "IsActice");
        }
    }
}
