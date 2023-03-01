﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace cakeshop.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230301144116_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Cakeshop.Models.ADMINISTRATOR", b =>
                {
                    b.Property<int>("AdministratorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AdministratorID");

                    b.ToTable("ADMINISTRATOR");
                });

            modelBuilder.Entity("Cakeshop.Models.CATEGORY", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CategoryID");

                    b.ToTable("CATEGORY");
                });

            modelBuilder.Entity("Cakeshop.Models.CUSTERMOR", b =>
                {
                    b.Property<int>("CustermorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone_Number")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CustermorID");

                    b.ToTable("CUSTERMOR");
                });

            modelBuilder.Entity("Cakeshop.Models.ORDER", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Order_Date")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Order_Time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Total_Cost")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.ToTable("ORDER");
                });

            modelBuilder.Entity("Cakeshop.Models.PAYMENT", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Payment_Details")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Payment_Method")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PaymentID");

                    b.ToTable("PAYMENT");
                });

            modelBuilder.Entity("Cakeshop.Models.PRODUCT", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Product_Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ProductID");

                    b.ToTable("PRODUCT");
                });
#pragma warning restore 612, 618
        }
    }
}
