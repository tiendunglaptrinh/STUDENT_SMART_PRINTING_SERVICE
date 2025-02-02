﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SMART_PRINTER_SERVICE.Data;

#nullable disable

namespace SMART_PRINTER_SERVICE.Migrations
{
    [DbContext(typeof(databaseSEContext))]
    [Migration("20231204071315_initsetup")]
    partial class initsetup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PrinterUserAccount", b =>
                {
                    b.Property<string>("PrinterIdmanagedsPrinterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UsernameManagersUsername")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PrinterIdmanagedsPrinterId", "UsernameManagersUsername");

                    b.HasIndex("UsernameManagersUsername");

                    b.ToTable("PrinterUserAccount");
                });

            modelBuilder.Entity("SMART_PRINTER_SERVICE.Models.Order", b =>
                {
                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Choice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colorfile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Copies")
                        .HasColumnType("int");

                    b.Property<DateTime>("DayOrder")
                        .HasColumnType("datetime2");

                    b.Property<string>("Filename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numpage")
                        .HasColumnType("int");

                    b.Property<int>("Numside")
                        .HasColumnType("int");

                    b.Property<string>("PrinterOrder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sizepage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("TimeOrder")
                        .HasColumnType("time");

                    b.Property<string>("UsernameOrder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsernameOrderNavigationUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("UsernameOrderNavigationUsername");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SMART_PRINTER_SERVICE.Models.Printer", b =>
                {
                    b.Property<string>("PrinterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Facility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrinterLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrinterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrinterId");

                    b.ToTable("Printers");
                });

            modelBuilder.Entity("SMART_PRINTER_SERVICE.Models.UserAccount", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Falcuty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Major")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PagePrint")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("PrinterUserAccount", b =>
                {
                    b.HasOne("SMART_PRINTER_SERVICE.Models.Printer", null)
                        .WithMany()
                        .HasForeignKey("PrinterIdmanagedsPrinterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SMART_PRINTER_SERVICE.Models.UserAccount", null)
                        .WithMany()
                        .HasForeignKey("UsernameManagersUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SMART_PRINTER_SERVICE.Models.Order", b =>
                {
                    b.HasOne("SMART_PRINTER_SERVICE.Models.UserAccount", "UsernameOrderNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("UsernameOrderNavigationUsername")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsernameOrderNavigation");
                });

            modelBuilder.Entity("SMART_PRINTER_SERVICE.Models.UserAccount", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
