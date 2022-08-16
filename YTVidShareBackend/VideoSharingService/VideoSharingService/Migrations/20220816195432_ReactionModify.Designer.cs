﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VideoSharingService.Data;

namespace VideoSharingService.Migrations
{
    [DbContext(typeof(VidShareDbContext))]
    [Migration("20220816195432_ReactionModify")]
    partial class ReactionModify
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VideoSharingService.Data.Models.Reaction", b =>
                {
                    b.Property<int>("ReactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReactedUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReactingTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Value")
                        .HasColumnType("bit");

                    b.Property<int>("VideoID")
                        .HasColumnType("int");

                    b.HasKey("ReactionID");

                    b.HasIndex("VideoID");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("VideoSharingService.Data.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            CreatedAt = new DateTime(2022, 8, 17, 1, 54, 31, 739, DateTimeKind.Local).AddTicks(1464),
                            Email = "admin@vidshare.com",
                            Password = "admin@1234",
                            Username = "Admin"
                        });
                });

            modelBuilder.Entity("VideoSharingService.Data.Models.Video", b =>
                {
                    b.Property<int>("VideoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("VideoID");

                    b.HasIndex("UserID");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("VideoSharingService.Data.Models.Reaction", b =>
                {
                    b.HasOne("VideoSharingService.Data.Models.Video", "Video")
                        .WithMany("Reactions")
                        .HasForeignKey("VideoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Video");
                });

            modelBuilder.Entity("VideoSharingService.Data.Models.Video", b =>
                {
                    b.HasOne("VideoSharingService.Data.Models.User", "User")
                        .WithMany("Videos")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("VideoSharingService.Data.Models.User", b =>
                {
                    b.Navigation("Videos");
                });

            modelBuilder.Entity("VideoSharingService.Data.Models.Video", b =>
                {
                    b.Navigation("Reactions");
                });
#pragma warning restore 612, 618
        }
    }
}
