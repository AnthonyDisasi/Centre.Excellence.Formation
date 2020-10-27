using Microsoft.EntityFrameworkCore.Migrations;

namespace Centre.Excellence.Formation.Migrations
{
    public partial class _init_Inventaire_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quatite",
                table: "Materiels",
                newName: "Quantite");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantite",
                table: "Materiels",
                newName: "Quatite");
        }
    }
}
