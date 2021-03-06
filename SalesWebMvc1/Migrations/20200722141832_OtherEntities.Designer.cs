﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWebMvc1.Data;

namespace SalesWebMvc1.Migrations
{
    [DbContext(typeof(SalesWebMvc1Context))]
    [Migration("20200722141832_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWebMvc1.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SalesWebMvc1.Models.SallesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SellerId");

                    b.Property<int?>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.HasIndex("StatusId");

                    b.ToTable("SallesRecord");
                });

            modelBuilder.Entity("SalesWebMvc1.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Selller");
                });

            modelBuilder.Entity("SalesWebMvc1.Models.SallesRecord", b =>
                {
                    b.HasOne("SalesWebMvc1.Models.Seller", "Seller")
                        .WithMany("Salles")
                        .HasForeignKey("SellerId");

                    b.HasOne("SalesWebMvc1.Models.SallesRecord", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");
                });

            modelBuilder.Entity("SalesWebMvc1.Models.Seller", b =>
                {
                    b.HasOne("SalesWebMvc1.Models.Department", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
