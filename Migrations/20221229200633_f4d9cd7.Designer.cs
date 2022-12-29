﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleEmployeeApp.Models.DataLayer;

#nullable disable

namespace SimpleEmployeeApp.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20221229200633_f4d9cd7")]
    partial class f4d9cd7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SimpleEmployeeApp.Models.DomainModels.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleInitial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("socialSecurityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            address = "3322 Davis Street",
                            city = "Carnesville",
                            dateOfBirth = new DateTime(1985, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            firstName = "Peter",
                            lastName = "Rowan",
                            middleInitial = "E.",
                            socialSecurityNumber = "671-24-6875",
                            state = "GA",
                            zip = "30521"
                        },
                        new
                        {
                            Id = 2,
                            address = "169 Breezewood Court",
                            city = "Coolidge",
                            dateOfBirth = new DateTime(1957, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            firstName = "Randall",
                            lastName = "Hatfield",
                            middleInitial = "W.",
                            socialSecurityNumber = "513-12-4682",
                            state = "KS",
                            zip = "67836"
                        },
                        new
                        {
                            Id = 3,
                            address = "3455 Dancing Dove Lane",
                            city = "NY",
                            dateOfBirth = new DateTime(1991, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            firstName = "Casey",
                            lastName = "Foster",
                            middleInitial = "A.",
                            socialSecurityNumber = "069-34-5134",
                            state = "New York",
                            zip = "10011"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}