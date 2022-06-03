﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwitterClone.Data;

#nullable disable

namespace TwitterClone.Migrations
{
    [DbContext(typeof(TweetDbContext))]
    [Migration("20220517181629_test1")]
    partial class test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TwitterClone.Models.Tweet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Shares")
                        .HasColumnType("int");

                    b.Property<int?>("TweetId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TweetId");

                    b.ToTable("Tweets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Likes = 3,
                            Message = "Hello World!",
                            PostedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shares = 0,
                            UserId = 0
                        });
                });

            modelBuilder.Entity("TwitterClone.Models.Tweet", b =>
                {
                    b.HasOne("TwitterClone.Models.Tweet", null)
                        .WithMany("Comments")
                        .HasForeignKey("TweetId");
                });

            modelBuilder.Entity("TwitterClone.Models.Tweet", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}