﻿// <auto-generated />
using Centre.Excellence.Formation.Areas.FormationPlaning.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Centre.Excellence.Formation.Migrations.DCFormationMigrations
{
    [DbContext(typeof(DCFormation))]
    partial class DCFormationModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Formateur", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresse")
                        .IsRequired();

                    b.Property<string>("Anciennete")
                        .IsRequired();

                    b.Property<string>("CheminCv")
                        .IsRequired();

                    b.Property<string>("Contact")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Genre");

                    b.Property<string>("NiveauEtude")
                        .IsRequired();

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.Property<string>("Postnom")
                        .IsRequired();

                    b.Property<string>("Prenom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Formateurs");
                });

            modelBuilder.Entity("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Formations", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Annee")
                        .IsRequired();

                    b.Property<string>("Cible")
                        .IsRequired();

                    b.Property<double>("CoutFormation");

                    b.Property<string>("Lieux")
                        .IsRequired();

                    b.Property<int>("Mois");

                    b.Property<string>("Observation")
                        .IsRequired();

                    b.Property<string>("Semaine")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Formations");
                });

            modelBuilder.Entity("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Former", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FormateurID");

                    b.Property<string>("FormationsID");

                    b.HasKey("ID");

                    b.HasIndex("FormateurID");

                    b.HasIndex("FormationsID");

                    b.ToTable("Formers");
                });

            modelBuilder.Entity("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Modules", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FormarteurID");

                    b.Property<string>("FormateurID");

                    b.Property<string>("Intituler")
                        .IsRequired();

                    b.Property<string>("Volume")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("FormateurID");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("Centre.Excellence.Formation.Areas.FormationPlaning.Models.NiveauEtude", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom");

                    b.HasKey("ID");

                    b.ToTable("NiveauEtudes");
                });

            modelBuilder.Entity("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Participant", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FormationsID");

                    b.Property<int>("Genre");

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.Property<string>("Postnom")
                        .IsRequired();

                    b.Property<string>("Prenom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("FormationsID");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Former", b =>
                {
                    b.HasOne("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Formateur", "Formateur")
                        .WithMany("Formers")
                        .HasForeignKey("FormateurID");

                    b.HasOne("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Formations", "Formation")
                        .WithMany("Formers")
                        .HasForeignKey("FormationsID");
                });

            modelBuilder.Entity("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Modules", b =>
                {
                    b.HasOne("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Formateur", "Formateur")
                        .WithMany("Modules")
                        .HasForeignKey("FormateurID");
                });

            modelBuilder.Entity("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Participant", b =>
                {
                    b.HasOne("Centre.Excellence.Formation.Areas.FormationPlaning.Models.Formations", "Formations")
                        .WithMany("Participants")
                        .HasForeignKey("FormationsID");
                });
#pragma warning restore 612, 618
        }
    }
}
