﻿// <auto-generated />
using System;
using EmployeesApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeesApi.Migrations
{
    [DbContext(typeof(EmployeesDataContext))]
    [Migration("20210909154718_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeesApi.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "QA",
                            FirstName = "Bob",
                            HireDate = new DateTime(2020, 11, 13, 11, 47, 17, 712, DateTimeKind.Local).AddTicks(6460),
                            IsActive = true,
                            LastName = "Smith",
                            Salary = 180000m
                        },
                        new
                        {
                            Id = 2,
                            Department = "CEO",
                            FirstName = "Sue",
                            HireDate = new DateTime(2016, 9, 10, 11, 47, 17, 715, DateTimeKind.Local).AddTicks(8171),
                            IsActive = true,
                            LastName = "Jones",
                            Salary = 250000m
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Ray",
                            HireDate = new DateTime(2021, 2, 21, 11, 47, 17, 715, DateTimeKind.Local).AddTicks(8213),
                            IsActive = false,
                            LastName = "Palmer",
                            Salary = 0m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
