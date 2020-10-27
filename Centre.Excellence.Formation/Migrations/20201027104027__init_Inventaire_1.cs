using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Centre.Excellence.Formation.Migrations
{
    public partial class _init_Inventaire_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fournitures",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournitures", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Localisations",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localisations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Materiels",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Quatite = table.Column<int>(nullable: false),
                    Marque = table.Column<string>(nullable: false),
                    Carecteristique = table.Column<string>(nullable: false),
                    NumeroSerie = table.Column<string>(nullable: false),
                    TAG = table.Column<string>(nullable: false),
                    AutreNumero = table.Column<string>(nullable: false),
                    Localisation = table.Column<string>(nullable: false),
                    Fournisseur = table.Column<string>(nullable: false),
                    SourceFinancement = table.Column<string>(nullable: false),
                    AnneeAcquisition = table.Column<string>(nullable: false),
                    Commentaire = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materiels", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mobiliers",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Quantite = table.Column<int>(nullable: false),
                    Localisation = table.Column<string>(nullable: false),
                    Etat = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobiliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Diagnostiques",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    MaterielID = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    Quatite = table.Column<int>(nullable: false),
                    Etat = table.Column<int>(nullable: false),
                    Besoin = table.Column<string>(nullable: false),
                    DateDiagnostique = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnostiques", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Diagnostiques_Materiels_MaterielID",
                        column: x => x.MaterielID,
                        principalTable: "Materiels",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diagnostiques_MaterielID",
                table: "Diagnostiques",
                column: "MaterielID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diagnostiques");

            migrationBuilder.DropTable(
                name: "Fournitures");

            migrationBuilder.DropTable(
                name: "Localisations");

            migrationBuilder.DropTable(
                name: "Mobiliers");

            migrationBuilder.DropTable(
                name: "Materiels");
        }
    }
}
