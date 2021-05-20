﻿// <auto-generated />
using System;
using EFCodeFirstAssignment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCodeFirstAssignment.Migrations
{
    [DbContext(typeof(BookDBContext))]
    [Migration("20210520070619_01_createtables")]
    partial class _01_createtables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCodeFirstAssignment.Book", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("EFCodeFirstAssignment.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("MemberName")
                        .HasColumnType("varchar(20)");

                    b.HasKey("MemberId");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("EFCodeFirstAssignment.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("PublisherCountry")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PublisherName")
                        .HasColumnType("varchar(20)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("EFCodeFirstAssignment.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .HasColumnType("varchar(20)");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.HasIndex("MemberId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("EFCodeFirstAssignment.Book", b =>
                {
                    b.HasOne("EFCodeFirstAssignment.Publisher", "Publisher")
                        .WithMany("PublisherBooks")
                        .HasForeignKey("PublisherId");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("EFCodeFirstAssignment.Review", b =>
                {
                    b.HasOne("EFCodeFirstAssignment.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId");

                    b.HasOne("EFCodeFirstAssignment.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId");

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("EFCodeFirstAssignment.Publisher", b =>
                {
                    b.Navigation("PublisherBooks");
                });
#pragma warning restore 612, 618
        }
    }
}