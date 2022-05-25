﻿// <auto-generated />
using AccountTask.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountTask.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("AccountTask.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ApartmentNumber")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Area")
                        .HasColumnType("REAL");

                    b.Property<string>("Building")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Locality")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResidentsNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
