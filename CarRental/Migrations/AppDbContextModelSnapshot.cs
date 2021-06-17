﻿// <auto-generated />
using System;
using CarRental.Models.CarRentalDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarRental.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarRental.Models.CarRentalDb.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<string>("Registration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarRental.Models.CarRentalDb.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surename")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Wallet")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CarRental.Models.CarRentalDb.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Capacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Horsepower")
                        .HasColumnType("int");

                    b.Property<int?>("carId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("carId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("CarRental.Models.CarRentalDb.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("carId")
                        .HasColumnType("int");

                    b.Property<int?>("clientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("carId");

                    b.HasIndex("clientId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CarRental.Models.CarRentalDb.Model", b =>
                {
                    b.HasOne("CarRental.Models.CarRentalDb.Car", "car")
                        .WithMany("Models")
                        .HasForeignKey("carId");

                    b.Navigation("car");
                });

            modelBuilder.Entity("CarRental.Models.CarRentalDb.Order", b =>
                {
                    b.HasOne("CarRental.Models.CarRentalDb.Car", "car")
                        .WithMany()
                        .HasForeignKey("carId");

                    b.HasOne("CarRental.Models.CarRentalDb.Client", "client")
                        .WithMany("Orders")
                        .HasForeignKey("clientId");

                    b.Navigation("car");

                    b.Navigation("client");
                });

            modelBuilder.Entity("CarRental.Models.CarRentalDb.Car", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("CarRental.Models.CarRentalDb.Client", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
