﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopEcommerce.Data;

#nullable disable

namespace ShopEcommerce.Data.migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240111165006_init-talble")]
    partial class inittalble
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShopEcommerce.Models.Cart", b =>
                {
                    b.Property<int>("IdCart")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCart"));

                    b.Property<int>("IdProduct")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.HasKey("IdCart");

                    b.HasIndex("IdProduct");

                    b.HasIndex("IdUser")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Category", b =>
                {
                    b.Property<int>("IdCategrory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategrory"));

                    b.Property<string>("NameCategroty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdCategrory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShopEcommerce.Models.GroupOption", b =>
                {
                    b.Property<int>("IdGroup")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGroup"));

                    b.Property<string>("NameGroup")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("ProductIdProduct")
                        .HasColumnType("int");

                    b.HasKey("IdGroup");

                    b.HasIndex("ProductIdProduct");

                    b.ToTable("GroupOptions");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Menu", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMenu"));

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("IsChildren")
                        .HasColumnType("int");

                    b.Property<bool>("IsParent")
                        .HasColumnType("bit");

                    b.Property<string>("LinkMenu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameMenu")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdMenu");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("ShopEcommerce.Models.OptionProduct", b =>
                {
                    b.Property<int>("IdOption")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOption"));

                    b.Property<int>("IdGroup")
                        .HasColumnType("int");

                    b.Property<string>("NameOption")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("PricePromtion")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("IdOption");

                    b.HasIndex("IdGroup");

                    b.ToTable("OptionProducts");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Post", b =>
                {
                    b.Property<int>("IdPost")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPost"));

                    b.Property<string>("AvatarPost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionPost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitlePost")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.HasKey("IdPost");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Product", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduct"));

                    b.Property<string>("AvatarImg")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DescriptionProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCategory")
                        .HasColumnType("int");

                    b.Property<int>("IdGroup")
                        .HasColumnType("int");

                    b.Property<string>("ImageProduct")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("IsHot")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNew")
                        .HasColumnType("bit");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<string>("TitleProduct")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.HasKey("IdProduct");

                    b.HasIndex("IdCategory");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShopEcommerce.Models.ProductModel", b =>
                {
                    b.Property<int>("IdProductModel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProductModel"));

                    b.Property<int>("GroupOptionIdGroup")
                        .HasColumnType("int");

                    b.Property<int>("IdGroupOtion")
                        .HasColumnType("int");

                    b.HasKey("IdProductModel");

                    b.HasIndex("GroupOptionIdGroup");

                    b.ToTable("ProductModels");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRole"));

                    b.Property<string>("NameRole")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ShopEcommerce.Models.User", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdRole")
                        .HasColumnType("int");

                    b.Property<string>("NumberPhone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUser");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.HasIndex("IdRole");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Cart", b =>
                {
                    b.HasOne("ShopEcommerce.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopEcommerce.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("ShopEcommerce.Models.Cart", "IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ShopEcommerce.Models.GroupOption", b =>
                {
                    b.HasOne("ShopEcommerce.Models.Product", null)
                        .WithMany("GroupOptions")
                        .HasForeignKey("ProductIdProduct");
                });

            modelBuilder.Entity("ShopEcommerce.Models.OptionProduct", b =>
                {
                    b.HasOne("ShopEcommerce.Models.GroupOption", "GroupOption")
                        .WithMany("OptionProducts")
                        .HasForeignKey("IdGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupOption");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Product", b =>
                {
                    b.HasOne("ShopEcommerce.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("IdCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShopEcommerce.Models.ProductModel", b =>
                {
                    b.HasOne("ShopEcommerce.Models.GroupOption", "GroupOption")
                        .WithMany()
                        .HasForeignKey("GroupOptionIdGroup")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupOption");
                });

            modelBuilder.Entity("ShopEcommerce.Models.User", b =>
                {
                    b.HasOne("ShopEcommerce.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("IdRole")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShopEcommerce.Models.GroupOption", b =>
                {
                    b.Navigation("OptionProducts");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Product", b =>
                {
                    b.Navigation("GroupOptions");
                });

            modelBuilder.Entity("ShopEcommerce.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("ShopEcommerce.Models.User", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
