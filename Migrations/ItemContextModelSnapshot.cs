﻿// <auto-generated />
using System;
using Bar_scan_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace bar_scan_api.Migrations
{
    [DbContext(typeof(ItemContext))]
    partial class ItemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Bar_scan_API.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AmountCounted")
                        .HasColumnType("integer");

                    b.Property<string>("Barcode")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ShelfOfOrigin")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
