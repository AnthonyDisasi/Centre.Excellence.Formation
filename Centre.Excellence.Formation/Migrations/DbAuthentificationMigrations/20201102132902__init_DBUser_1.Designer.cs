﻿// <auto-generated />
using Centre.Excellence.Formation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Centre.Excellence.Formation.Migrations.DbAuthentificationMigrations
{
    [DbContext(typeof(DbAuthentification))]
    [Migration("20201102132902__init_DBUser_1")]
    partial class _init_DBUser_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Centre.Excellence.Formation.Models.Personne", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom");

                    b.Property<string>("Password");

                    b.Property<string>("Prenom")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Personnes");
                });
#pragma warning restore 612, 618
        }
    }
}
