﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210216080125_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("ContactManagementSystemwebAPI.Models.ContactGroups", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("ContactGroups");
                });

            modelBuilder.Entity("ContactManagementSystemwebAPI.Models.ContactTags", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("contactID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("tagID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("ContactTags");
                });

            modelBuilder.Entity("ContactManagementSystemwebAPI.Models.Contacts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("birthdate")
                        .HasColumnType("TEXT");

                    b.Property<int>("contactGroupID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("favoriteFlag")
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ContactManagementSystemwebAPI.Models.Tags", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}