using Microsoft.EntityFrameworkCore.Migrations;

namespace Centre.Excellence.Formation.Migrations
{
    public partial class _init_Inventaire_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quatite",
                table: "Diagnostiques",
                newName: "Quantite");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantite",
                table: "Diagnostiques",
                newName: "Quatite");
        }
    }
}
