﻿// <auto-generated />
using System;
using HepsiBurada.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HepsiBurada.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("HepsiBurada.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 412, DateTimeKind.Local).AddTicks(947),
                            IsDeleted = false,
                            Name = "Electronics & Automotive"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 412, DateTimeKind.Local).AddTicks(974),
                            IsDeleted = false,
                            Name = "Books, Garden & Movies"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 412, DateTimeKind.Local).AddTicks(989),
                            IsDeleted = true,
                            Name = "Toys, Automotive & Games"
                        });
                });

            modelBuilder.Entity("HepsiBurada.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 412, DateTimeKind.Local).AddTicks(4539),
                            IsDeleted = false,
                            Name = "Elektrik",
                            ParentId = 0,
                            Priority = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 412, DateTimeKind.Local).AddTicks(4541),
                            IsDeleted = false,
                            Name = "Moda",
                            ParentId = 0,
                            Priority = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 412, DateTimeKind.Local).AddTicks(4543),
                            IsDeleted = false,
                            Name = "Bilgisayar",
                            ParentId = 1,
                            Priority = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 412, DateTimeKind.Local).AddTicks(4544),
                            IsDeleted = false,
                            Name = "Kadın",
                            ParentId = 2,
                            Priority = 1
                        });
                });

            modelBuilder.Entity("HepsiBurada.Domain.Entities.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 415, DateTimeKind.Local).AddTicks(1135),
                            Description = "Neque aperiam enim beğendim sandalye.",
                            IsDeleted = false,
                            Title = "Bahar."
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 415, DateTimeKind.Local).AddTicks(1169),
                            Description = "Nemo alias çorba qui nesciunt.",
                            IsDeleted = true,
                            Title = "Architecto anlamsız."
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 415, DateTimeKind.Local).AddTicks(1198),
                            Description = "Ut oldular salladı beatae dağılımı.",
                            IsDeleted = false,
                            Title = "Filmini."
                        });
                });

            modelBuilder.Entity("HepsiBurada.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 417, DateTimeKind.Local).AddTicks(9099),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Discount = 9.764249490870840m,
                            IsDeleted = false,
                            Price = 475.05m,
                            Title = "Fantastic Soft Computer"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 3,
                            CreatedDate = new DateTime(2024, 11, 15, 12, 45, 31, 417, DateTimeKind.Local).AddTicks(9127),
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Discount = 5.388138576273080m,
                            IsDeleted = false,
                            Price = 465.89m,
                            Title = "Unbranded Wooden Towels"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("HepsiBurada.Domain.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HepsiBurada.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HepsiBurada.Domain.Entities.Detail", b =>
                {
                    b.HasOne("HepsiBurada.Domain.Entities.Category", "Category")
                        .WithMany("Details")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HepsiBurada.Domain.Entities.Product", b =>
                {
                    b.HasOne("HepsiBurada.Domain.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("HepsiBurada.Domain.Entities.Category", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
