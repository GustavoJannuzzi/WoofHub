﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WoofHub_App.Data;

#nullable disable

namespace WoofHub_App.Migrations
{
    [DbContext(typeof(WoofHubContext))]
    partial class WoofHubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WoofHub_App.Models.AdressModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cep")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Number")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AdressModel");
                });

            modelBuilder.Entity("WoofHub_App.Models.AnimalModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Animal")
                        .HasColumnType("int");

                    b.Property<string>("AnimalName")
                        .HasColumnType("longtext");

                    b.Property<int?>("ClientModelId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("varchar(5000)");

                    b.Property<int>("Situation")
                        .HasColumnType("int");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Treatment")
                        .HasColumnType("int");

                    b.Property<int>("Vaccine")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientModelId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("WoofHub_App.Models.ClientModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientAdressId")
                        .HasColumnType("int");

                    b.Property<string>("ClientCpf")
                        .HasColumnType("longtext");

                    b.Property<string>("ClientName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ClientAdressId");

                    b.ToTable("ClientModel");
                });

            modelBuilder.Entity("WoofHub_App.Models.AnimalModel", b =>
                {
                    b.HasOne("WoofHub_App.Models.ClientModel", "ClientModel")
                        .WithMany()
                        .HasForeignKey("ClientModelId");

                    b.Navigation("ClientModel");
                });

            modelBuilder.Entity("WoofHub_App.Models.ClientModel", b =>
                {
                    b.HasOne("WoofHub_App.Models.AdressModel", "ClientAdress")
                        .WithMany()
                        .HasForeignKey("ClientAdressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientAdress");
                });
#pragma warning restore 612, 618
        }
    }
}
