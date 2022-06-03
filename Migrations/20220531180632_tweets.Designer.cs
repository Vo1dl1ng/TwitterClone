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
    [Migration("20220531180632_tweets")]
    partial class tweets
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
                            Shares = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Likes = 2,
                            Message = "What website is this?",
                            PostedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shares = 6,
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Likes = 6,
                            Message = "It's sunny today",
                            PostedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shares = 5,
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Likes = 9,
                            Message = "aaaannd it started raining T_T",
                            PostedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shares = 7,
                            UserId = 3
                        },
                        new
                        {
                            Id = 5,
                            Likes = 5,
                            Message = "went hiking today",
                            PostedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Shares = 6,
                            UserId = 4
                        });
                });

            modelBuilder.Entity("TwitterClone.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwitterHandle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageURL = "ExampleUrl",
                            TwitterHandle = "ExampleHandle",
                            UserName = "ExampleName"
                        },
                        new
                        {
                            Id = 2,
                            ImageURL = "TesteUrl",
                            TwitterHandle = "TestHandle",
                            UserName = "TestName"
                        },
                        new
                        {
                            Id = 3,
                            ImageURL = "TesterUrl",
                            TwitterHandle = "TesterHandle",
                            UserName = "TesterName"
                        },
                        new
                        {
                            Id = 4,
                            ImageURL = "BetaUrl",
                            TwitterHandle = "BetaHandle",
                            UserName = "BetaName"
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