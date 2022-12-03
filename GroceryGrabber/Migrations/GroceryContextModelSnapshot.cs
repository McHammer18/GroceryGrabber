﻿// <auto-generated />
using System;
using GroceryGrabber.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroceryGrabber.Migrations
{
    [DbContext(typeof(GroceryContext))]
    partial class GroceryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GroceryGrabber.Models.GroceryItem", b =>
                {
                    b.Property<int>("GroceryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroceryId"), 1L, 1);

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("GroceryId");

                    b.ToTable("GroceryItems");

                    b.HasData(
                        new
                        {
                            GroceryId = 1,
                            Department = "Meat",
                            Description = "Role of ground Hamburger Meat",
                            Location = "Meat Counter/ Aisle 65",
                            Name = "1lbs Hamburger",
                            Price = 0f
                        },
                        new
                        {
                            GroceryId = 2,
                            Department = "Produce",
                            Description = "1 Head of Iceburg Lettuce",
                            Location = "Aisle 42",
                            Name = "Lettuce",
                            Price = 0f
                        },
                        new
                        {
                            GroceryId = 3,
                            Department = "Produce",
                            Description = "5 lbs bag of Honey Crisp",
                            Location = "Aisle 44",
                            Name = "Apples",
                            Price = 0f
                        },
                        new
                        {
                            GroceryId = 4,
                            Department = "Deli",
                            Description = "1 lbs of Turkey slices",
                            Location = "Deli Counter/ Aisle 55",
                            Name = "Sliced Turkey",
                            Price = 0f
                        },
                        new
                        {
                            GroceryId = 5,
                            Department = "Bakery",
                            Description = "1 loaf of White Whole Grain",
                            Location = "Aisle 20",
                            Name = "Bread",
                            Price = 0f
                        });
                });

            modelBuilder.Entity("GroceryGrabber.Models.UserModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GroceryGrabber.Models.UsersLists", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("GroceryId")
                        .HasColumnType("int");

                    b.Property<int?>("ItemGroceryId")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("id");

                    b.HasIndex("ItemGroceryId");

                    b.HasIndex("UserId");

                    b.ToTable("GroceryList");
                });

            modelBuilder.Entity("GroceryGrabber.Models.UsersLists", b =>
                {
                    b.HasOne("GroceryGrabber.Models.GroceryItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemGroceryId");

                    b.HasOne("GroceryGrabber.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Item");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
