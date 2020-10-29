using Microsoft.EntityFrameworkCore.Migrations;

namespace Centre.Excellence.Formation.Migrations.DCFormationMigrations
{
    public partial class _init_DBFormateur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formateurs",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Postnom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    Genre = table.Column<int>(nullable: false),
                    NiveauEtude = table.Column<string>(nullable: false),
                    Anciennete = table.Column<string>(nullable: false),
                    Contact = table.Column<string>(nullable: false),
                    Adresse = table.Column<string>(nullable: false),
                    CheminCv = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formateurs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Formations",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Mois = table.Column<int>(nullable: false),
                    Lieux = table.Column<string>(nullable: false),
                    Semaine = table.Column<string>(nullable: false),
                    Cible = table.Column<string>(nullable: false),
                    CoutFormation = table.Column<double>(nullable: false),
                    Observation = table.Column<string>(nullable: false),
                    Annee = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NiveauEtudes",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NiveauEtudes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FormarteurID = table.Column<string>(nullable: true),
                    Intituler = table.Column<string>(nullable: false),
                    Volume = table.Column<string>(nullable: false),
                    FormateurID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Modules_Formateurs_FormateurID",
                        column: x => x.FormateurID,
                        principalTable: "Formateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Formers",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FormateurID = table.Column<string>(nullable: true),
                    FormationsID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Formers_Formateurs_FormateurID",
                        column: x => x.FormateurID,
                        principalTable: "Formateurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Formers_Formations_FormationsID",
                        column: x => x.FormationsID,
                        principalTable: "Formations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    FormationsID = table.Column<string>(nullable: true),
                    Nom = table.Column<string>(nullable: false),
                    Postnom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    Genre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Participants_Formations_FormationsID",
                        column: x => x.FormationsID,
                        principalTable: "Formations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Formers_FormateurID",
                table: "Formers",
                column: "FormateurID");

            migrationBuilder.CreateIndex(
                name: "IX_Formers_FormationsID",
                table: "Formers",
                column: "FormationsID");

            migrationBuilder.CreateIndex(
                name: "IX_Modules_FormateurID",
                table: "Modules",
                column: "FormateurID");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_FormationsID",
                table: "Participants",
                column: "FormationsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Formers");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "NiveauEtudes");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Formateurs");

            migrationBuilder.DropTable(
                name: "Formations");
        }
    }
}
