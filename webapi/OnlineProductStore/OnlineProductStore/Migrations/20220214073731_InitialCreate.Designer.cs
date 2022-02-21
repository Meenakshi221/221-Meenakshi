﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineProductStore.Data;

namespace OnlineProductStore.Migrations
{
    [DbContext(typeof(OrdersContext))]
    [Migration("20220214073731_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineProductStore.Models.Order", b =>
                {
                    b.Property<int>("OrderNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("LoginId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserLoginId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("OrderNumber");

                    b.HasIndex("UserLoginId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("OnlineProductStore.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int>("ProductAmount")
                        .HasColumnType("int");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailsID");

                    b.HasIndex("OrderNumber");

                    b.HasIndex("ProductCode");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("OnlineProductStore.Models.Product", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductCode");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("OnlineProductStore.Models.User", b =>
                {
                    b.Property<string>("LoginId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LoginId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("OnlineProductStore.Models.Order", b =>
                {
                    b.HasOne("OnlineProductStore.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserLoginId");
                });

            modelBuilder.Entity("OnlineProductStore.Models.OrderDetail", b =>
                {
                    b.HasOne("OnlineProductStore.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderNumber");

                    b.HasOne("OnlineProductStore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductCode");
                });
#pragma warning restore 612, 618
        }
    }
}