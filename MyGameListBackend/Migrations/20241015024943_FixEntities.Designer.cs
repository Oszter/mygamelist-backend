﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyGameList.Data;

#nullable disable

namespace MyGameListBackend.Migrations
{
    [DbContext(typeof(MyGameListContext))]
    [Migration("20241015024943_FixEntities")]
    partial class FixEntities
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenresId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("GameGenre");
                });

            modelBuilder.Entity("GamePlatform", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PlatformsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GameId", "PlatformsId");

                    b.HasIndex("PlatformsId");

                    b.ToTable("GamePlatform");
                });

            modelBuilder.Entity("GameTracker", b =>
                {
                    b.Property<int>("GamesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrackersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GamesId", "TrackersId");

                    b.HasIndex("TrackersId");

                    b.ToTable("GameTracker");
                });

            modelBuilder.Entity("MyGameList.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(180)
                        .HasColumnType("TEXT");

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("MyGameList.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("MyGameList.Models.OperationalSystem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("OperationalSystem");
                });

            modelBuilder.Entity("MyGameList.Models.Platform", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<int>("OperationalSystemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OperationalSystemId");

                    b.ToTable("Platform");
                });

            modelBuilder.Entity("MyGameList.Models.Tracker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrackerCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TrackerCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Tracker");
                });

            modelBuilder.Entity("MyGameList.Models.TrackerCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TrackerCategory");
                });

            modelBuilder.Entity("MyGameList.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SignUpSince")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GameGenre", b =>
                {
                    b.HasOne("MyGameList.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyGameList.Models.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GamePlatform", b =>
                {
                    b.HasOne("MyGameList.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyGameList.Models.Platform", null)
                        .WithMany()
                        .HasForeignKey("PlatformsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameTracker", b =>
                {
                    b.HasOne("MyGameList.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyGameList.Models.Tracker", null)
                        .WithMany()
                        .HasForeignKey("TrackersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyGameList.Models.Platform", b =>
                {
                    b.HasOne("MyGameList.Models.OperationalSystem", "OperationalSystem")
                        .WithMany()
                        .HasForeignKey("OperationalSystemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OperationalSystem");
                });

            modelBuilder.Entity("MyGameList.Models.Tracker", b =>
                {
                    b.HasOne("MyGameList.Models.TrackerCategory", "TrackerCategory")
                        .WithMany()
                        .HasForeignKey("TrackerCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyGameList.Models.User", null)
                        .WithMany("Tracker")
                        .HasForeignKey("UserId");

                    b.Navigation("TrackerCategory");
                });

            modelBuilder.Entity("MyGameList.Models.User", b =>
                {
                    b.Navigation("Tracker");
                });
#pragma warning restore 612, 618
        }
    }
}
