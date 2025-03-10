﻿// <auto-generated />
using System;
using ASM.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASM.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASM.Server.Models.Combo", b =>
                {
                    b.Property<int>("ComboId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComboId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ComboId");

                    b.ToTable("Combos");
                });

            modelBuilder.Entity("ASM.Server.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("CustomerId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ASM.Server.Models.FoodItem", b =>
                {
                    b.Property<int>("FoodItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodItemId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FoodItemId");

                    b.ToTable("FoodItems");
                });

            modelBuilder.Entity("ASM.Server.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ASM.Server.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("FoodItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "FoodItemId");

                    b.HasIndex("FoodItemId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ASM.Server.Models.Review", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("FoodItemId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FoodItemId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("FoodItemId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("ASM.Server.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ComboFoodItem", b =>
                {
                    b.Property<int>("CombosComboId")
                        .HasColumnType("int");

                    b.Property<int>("FoodItemsFoodItemId")
                        .HasColumnType("int");

                    b.HasKey("CombosComboId", "FoodItemsFoodItemId");

                    b.HasIndex("FoodItemsFoodItemId");

                    b.ToTable("ComboFoodItem");
                });

            modelBuilder.Entity("ASM.Server.Models.Order", b =>
                {
                    b.HasOne("ASM.Server.Models.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("ASM.Server.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ASM.Server.Models.OrderDetail", b =>
                {
                    b.HasOne("ASM.Server.Models.FoodItem", "FoodItem")
                        .WithMany("OrderDetails")
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM.Server.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ASM.Server.Models.Review", b =>
                {
                    b.HasOne("ASM.Server.Models.Customer", null)
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId");

                    b.HasOne("ASM.Server.Models.FoodItem", "FoodItem")
                        .WithMany("Reviews")
                        .HasForeignKey("FoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM.Server.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodItem");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ComboFoodItem", b =>
                {
                    b.HasOne("ASM.Server.Models.Combo", null)
                        .WithMany()
                        .HasForeignKey("CombosComboId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASM.Server.Models.FoodItem", null)
                        .WithMany()
                        .HasForeignKey("FoodItemsFoodItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASM.Server.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("ASM.Server.Models.FoodItem", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("ASM.Server.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("ASM.Server.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
