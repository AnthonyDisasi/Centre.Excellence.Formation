﻿// <auto-generated />
using System;
using Centre.Excellence.Formation.Areas.Inventaire.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Centre.Excellence.Formation.Migrations
{
    [DbContext(typeof(DCInventaire))]
    partial class DCInventaireModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CentreFormation.Areas.Inventaire.Models.Diagnostique", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Besoin")
                        .IsRequired();

                    b.Property<DateTime>("DateDiagnostique");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Etat");

                    b.Property<string>("MaterielID");

                    b.Property<int>("Quatite");

                    b.HasKey("ID");

                    b.HasIndex("MaterielID");

                    b.ToTable("Diagnostiques");
                });

            modelBuilder.Entity("CentreFormation.Areas.Inventaire.Models.Fourniture", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom");

                    b.HasKey("ID");

                    b.ToTable("Fournitures");
                });

            modelBuilder.Entity("CentreFormation.Areas.Inventaire.Models.Localisation", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nom");

                    b.HasKey("ID");

                    b.ToTable("Localisations");
                });

            modelBuilder.Entity("CentreFormation.Areas.Inventaire.Models.Materiel", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnneeAcquisition")
                        .IsRequired();

                    b.Property<string>("AutreNumero")
                        .IsRequired();

                    b.Property<string>("Carecteristique")
                        .IsRequired();

                    b.Property<string>("Commentaire")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Fournisseur")
                        .IsRequired();

                    b.Property<string>("Localisation")
                        .IsRequired();

                    b.Property<string>("Marque")
                        .IsRequired();

                    b.Property<string>("NumeroSerie")
                        .IsRequired();

                    b.Property<int>("Quatite");

                    b.Property<string>("SourceFinancement")
                        .IsRequired();

                    b.Property<string>("TAG")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Materiels");
                });

            modelBuilder.Entity("CentreFormation.Areas.Inventaire.Models.Mobilier", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Etat");

                    b.Property<string>("Localisation")
                        .IsRequired();

                    b.Property<int>("Quantite");

                    b.HasKey("ID");

                    b.ToTable("Mobiliers");
                });

            modelBuilder.Entity("CentreFormation.Areas.Inventaire.Models.Diagnostique", b =>
                {
                    b.HasOne("CentreFormation.Areas.Inventaire.Models.Materiel", "Materiel")
                        .WithMany("Diagnostiques")
                        .HasForeignKey("MaterielID");
                });
#pragma warning restore 612, 618
        }
    }
}
