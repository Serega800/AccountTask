﻿// <auto-generated />
using System;
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
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Area")
                        .HasColumnType("REAL");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long?>("PropertyAddressId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidentsCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PropertyAddressId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("AccountTask.Models.Address", b =>
                {
                    b.HasBaseType("AccountTask.Models.Account");

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Building")
                        .HasColumnType("TEXT");

                    b.Property<string>("Case")
                        .HasColumnType("TEXT");

                    b.Property<string>("Locality")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AccountTask.Models.Account", b =>
                {
                    b.HasOne("AccountTask.Models.Address", "PropertyAddress")
                        .WithMany()
                        .HasForeignKey("PropertyAddressId");

                    b.Navigation("PropertyAddress");
                });

            modelBuilder.Entity("AccountTask.Models.Address", b =>
                {
                    b.HasOne("AccountTask.Models.Account", null)
                        .WithOne()
                        .HasForeignKey("AccountTask.Models.Address", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
