﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyUniversityProject.Models;

namespace MyUniversityProject.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191102182303_NewMig5")]
    partial class NewMig5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyUniversityProject.Models.Cell", b =>
                {
                    b.Property<int>("CellId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity");

                    b.Property<int>("Height");

                    b.Property<int>("Length");

                    b.Property<int>("StandardId");

                    b.Property<bool>("Status");

                    b.Property<int>("StorageId");

                    b.Property<int>("Width");

                    b.HasKey("CellId");

                    b.HasIndex("StandardId");

                    b.HasIndex("StorageId");

                    b.ToTable("Cells");
                });

            modelBuilder.Entity("MyUniversityProject.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataWorkStart");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("PassportId")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Role");

                    b.Property<decimal>("Salary");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("MyUniversityProject.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CellId");

                    b.Property<DateTime>("EndReservation");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("StartReservation");

                    b.Property<bool>("Status");

                    b.Property<int>("UserInfoId");

                    b.HasKey("ReservationId");

                    b.HasIndex("CellId");

                    b.HasIndex("UserInfoId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("MyUniversityProject.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("EndWork");

                    b.Property<DateTime>("StartWork");

                    b.Property<int>("StorageId");

                    b.Property<string>("WeekDay");

                    b.HasKey("ScheduleId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("StorageId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("MyUniversityProject.Models.Standard", b =>
                {
                    b.Property<int>("StandardId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxVolume");

                    b.Property<int>("MinVolume");

                    b.Property<decimal>("Price");

                    b.HasKey("StandardId");

                    b.ToTable("Standards");
                });

            modelBuilder.Entity("MyUniversityProject.Models.Storage", b =>
                {
                    b.Property<int>("StorageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<bool>("Status");

                    b.HasKey("StorageId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("MyUniversityProject.Models.UserInfo", b =>
                {
                    b.Property<int>("UserInfoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("PassportId");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("UserInfoId");

                    b.ToTable("UserInfos");
                });

            modelBuilder.Entity("MyUniversityProject.Models.Cell", b =>
                {
                    b.HasOne("MyUniversityProject.Models.Standard", "Standard")
                        .WithMany("Cells")
                        .HasForeignKey("StandardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyUniversityProject.Models.Storage", "Storage")
                        .WithMany("Cells")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyUniversityProject.Models.Reservation", b =>
                {
                    b.HasOne("MyUniversityProject.Models.Cell", "Cell")
                        .WithMany("Reservations")
                        .HasForeignKey("CellId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyUniversityProject.Models.UserInfo", "UserInfo")
                        .WithMany("Reservations")
                        .HasForeignKey("UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyUniversityProject.Models.Schedule", b =>
                {
                    b.HasOne("MyUniversityProject.Models.Employee", "Employee")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyUniversityProject.Models.Storage", "Storage")
                        .WithMany("Schedules")
                        .HasForeignKey("StorageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
