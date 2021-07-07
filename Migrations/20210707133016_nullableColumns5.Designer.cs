﻿// <auto-generated />
using System;
using Bookish.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookish.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20210707133016_nullableColumns5")]
    partial class nullableColumns5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bookish.DbModels.BookTypeDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isbn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookTypes");
                });

            modelBuilder.Entity("Bookish.DbModels.LiveBookDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookTypeId");

                    b.HasIndex("MemberId");

                    b.ToTable("LiveBooks");
                });

            modelBuilder.Entity("Bookish.DbModels.MemberDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Bookish.DbModels.LiveBookDbModel", b =>
                {
                    b.HasOne("Bookish.DbModels.BookTypeDbModel", "BookType")
                        .WithMany("LiveBooks")
                        .HasForeignKey("BookTypeId");

                    b.HasOne("Bookish.DbModels.MemberDbModel", "Member")
                        .WithMany("LiveBooks")
                        .HasForeignKey("MemberId");

                    b.Navigation("BookType");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Bookish.DbModels.BookTypeDbModel", b =>
                {
                    b.Navigation("LiveBooks");
                });

            modelBuilder.Entity("Bookish.DbModels.MemberDbModel", b =>
                {
                    b.Navigation("LiveBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
