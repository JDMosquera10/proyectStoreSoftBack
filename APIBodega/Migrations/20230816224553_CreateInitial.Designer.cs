﻿// <auto-generated />
using APIBodega.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIBodega.Migrations
{
    [DbContext(typeof(BodegaContext))]
    [Migration("20230816224553_CreateInitial")]
    partial class CreateInitial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIBodega.Models.Bodega", b =>
                {
                    b.Property<string>("bo_cdgo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("bo_actva")
                        .HasColumnType("int");

                    b.Property<string>("bo_dscrpcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bo_plnta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("bo_prpia")
                        .HasColumnType("int");

                    b.HasKey("bo_cdgo");

                    b.ToTable("bdga");
                });

            modelBuilder.Entity("APIBodega.Models.Permisos", b =>
                {
                    b.Property<int>("up_rowid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("up_rowid"));

                    b.Property<int>("up_adcnar")
                        .HasColumnType("int");

                    b.Property<int>("up_brrar")
                        .HasColumnType("int");

                    b.Property<int>("up_lstar")
                        .HasColumnType("int");

                    b.Property<int>("up_mdfcar")
                        .HasColumnType("int");

                    b.HasKey("up_rowid");

                    b.ToTable("usrio_prmso");
                });
#pragma warning restore 612, 618
        }
    }
}
