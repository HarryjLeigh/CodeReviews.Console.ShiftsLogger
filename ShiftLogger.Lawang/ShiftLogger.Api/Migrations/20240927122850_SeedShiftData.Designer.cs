﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShiftLogger.Api.Data;

#nullable disable

namespace ShiftLogger.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240927122850_SeedShiftData")]
    partial class SeedShiftData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShiftLogger.Api.Models.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Shifts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeName = "Adam",
                            End = new DateTime(2024, 9, 26, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2024, 9, 26, 12, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EmployeeName = "Eve",
                            End = new DateTime(2024, 9, 26, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Start = new DateTime(2024, 9, 26, 12, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}