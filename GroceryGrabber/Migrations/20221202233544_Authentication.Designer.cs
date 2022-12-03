﻿// <auto-generated />
using System;
using GroceryGrabber.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroceryGrabber.Migrations
{
    [DbContext(typeof(GroceryContext))]
    [Migration("20221202233544_Authentication")]
    partial class Authentication
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
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
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b28ce0c2-8a41-42cb-ac2f-0ed703a21629",
                            EmailConfirmed = false,
                            Id = "acdd5a56-4c36-4d5c-a0a5-08de958d31ea",
                            LockoutEnabled = false,
                            Name = "Morgan",
                            Password = "P@ssw0rd1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0ec521d2-7fbf-4492-8254-80f2cdb555e0",
                            TwoFactorEnabled = false,
                            UserName = "MorganC"
                        },
                        new
                        {
                            UserId = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e6ccfb11-fe71-4ae6-866c-cea1dcb89a81",
                            EmailConfirmed = false,
                            Id = "38ae9764-0653-41f8-9a6f-6c23c9853f05",
                            LockoutEnabled = false,
                            Name = "Taylor",
                            Password = "P@ssw0rd1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fd7ebf7c-94ee-4b81-829c-4e99773a8165",
                            TwoFactorEnabled = false,
                            UserName = "LadyLuck"
                        },
                        new
                        {
                            UserId = 3,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bcb6c40f-661b-4feb-9719-f17670db4344",
                            EmailConfirmed = false,
                            Id = "f263091e-b143-4a8f-9acd-d36cc0404ec4",
                            LockoutEnabled = false,
                            Name = "Deaon",
                            Password = "P@ssw0rd1",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b3aa50fd-9138-416b-b2e7-7287f4e3c2a7",
                            TwoFactorEnabled = false,
                            UserName = "DeonD"
                        });
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

                    b.HasKey("id");

                    b.HasIndex("ItemGroceryId");

                    b.HasIndex("UserID");

                    b.ToTable("GroceryList");

                    b.HasData(
                        new
                        {
                            id = 1,
                            GroceryId = 1,
                            UserID = 1
                        });
                });

            modelBuilder.Entity("GroceryGrabber.Models.UsersLists", b =>
                {
                    b.HasOne("GroceryGrabber.Models.GroceryItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemGroceryId");

                    b.HasOne("GroceryGrabber.Models.UserModel", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
