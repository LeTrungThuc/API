﻿// <auto-generated />
using System;
using Contacts_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Contacts_API.Migrations
{
    [DbContext(typeof(ContactsAPIDbContext))]
    [Migration("20240303023052_Table_Migration")]
    partial class Table_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Contacts_API.Models.Contact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Contacts_API.Models.Customer", b =>
                {
                    b.Property<Guid>("Id_CT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.HasKey("Id_CT");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Contacts_API.Models.ProductStatus", b =>
                {
                    b.Property<Guid>("Id_PrST")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Actual_process")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inventory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("System_process")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_PrST");

                    b.ToTable("ProductStatuses");
                });

            modelBuilder.Entity("Contacts_API.Models.Products", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("COD")
                        .HasColumnType("real");

                    b.Property<string>("Channel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Customers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Day")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Delivery")
                        .HasColumnType("bit");

                    b.Property<bool>("Operation")
                        .HasColumnType("bit");

                    b.Property<string>("Order_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Pay")
                        .HasColumnType("bit");

                    b.Property<int>("Product_ID")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Contacts_API.Models.Transport", b =>
                {
                    b.Property<Guid>("Id_DL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Actual_weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("COD")
                        .HasColumnType("real");

                    b.Property<int>("Ma_KMHCV")
                        .HasColumnType("int");

                    b.Property<string>("Noti")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shipping_fee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transport_fee")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("converted_volume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_DL");

                    b.ToTable("Transports");
                });
#pragma warning restore 612, 618
        }
    }
}
