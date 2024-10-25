﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WatchStoreApi.Data;

#nullable disable

namespace WatchStoreApi.Migrations
{
    [DbContext(typeof(WatchStoreDbContext))]
    partial class WatchStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WatchStoreApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Oyster, 36 mm, Oystersteel and white gold",
                            Image = "/Images/Rolex/datejust36.png",
                            Name = "Rolex Datejust 36",
                            Price = 18500m,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Oyster, 41 mm, Oystersteel",
                            Image = "/Images/Rolex/submariner41.png",
                            Name = "Rolex Submariner 41",
                            Price = 18300m,
                            Quantity = 7
                        });
                });

            modelBuilder.Entity("WatchStoreApi.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Rolex"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Hublot"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Patek Philippe"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Breitling"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Tissot"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Omega"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
