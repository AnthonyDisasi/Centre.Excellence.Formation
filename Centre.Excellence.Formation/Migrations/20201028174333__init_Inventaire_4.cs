using Microsoft.EntityFrameworkCore.Migrations;

namespace Centre.Excellence.Formation.Migrations
{
    public partial class _init_Inventaire_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Etat",
                table: "Diagnostiques",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Etat",
                table: "Diagnostiques",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
