﻿// <auto-generated />
using System;
using Bank.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bank.Data.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20230907170751_InitialCreate2")]
    partial class InitialCreate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bank.Entity.Concrete.CustomerAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BankBranch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CustomerAccountBalance")
                        .HasColumnType("bit");

                    b.Property<string>("CustomerAccountCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerAccountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CustomerAccounts");
                });

            modelBuilder.Entity("Bank.Entity.Concrete.CustomerAccountTransictions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Amount")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ProcessDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TransictionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CustomerAccountTransictionses");
                });
#pragma warning restore 612, 618
        }
    }
}