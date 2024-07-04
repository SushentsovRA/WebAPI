﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(WebAPIDbContext))]
    partial class WebAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<int>("CompositionId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TheaterId")
                        .HasColumnType("int");

                    b.HasKey("AuthorId");

                    b.HasIndex("CompositionId");

                    b.HasIndex("TheaterId");

                    b.ToTable("Author", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Composition", b =>
                {
                    b.Property<int>("CompositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompositionId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("HeroesInfo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CompositionId");

                    b.ToTable("Composition", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Play", b =>
                {
                    b.Property<int>("PlayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlayId"));

                    b.Property<int>("CompositionId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("EndDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTimeUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("TheaterId")
                        .HasColumnType("int");

                    b.HasKey("PlayId");

                    b.HasIndex("CompositionId");

                    b.HasIndex("TheaterId");

                    b.ToTable("Play", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Theater", b =>
                {
                    b.Property<int>("TheaterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TheaterId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<TimeOnly>("CloseTime")
                        .HasColumnType("time");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("FirstOpenDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<TimeOnly>("OpenTime")
                        .HasColumnType("time");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TheaterId");

                    b.ToTable("Theater", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Author", b =>
                {
                    b.HasOne("Domain.Entities.Composition", null)
                        .WithMany("Authors")
                        .HasForeignKey("CompositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Theater", null)
                        .WithMany("Authors")
                        .HasForeignKey("TheaterId");
                });

            modelBuilder.Entity("Domain.Entities.Play", b =>
                {
                    b.HasOne("Domain.Entities.Composition", null)
                        .WithMany("Plays")
                        .HasForeignKey("CompositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Theater", null)
                        .WithMany("Plays")
                        .HasForeignKey("TheaterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Composition", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Plays");
                });

            modelBuilder.Entity("Domain.Entities.Theater", b =>
                {
                    b.Navigation("Authors");

                    b.Navigation("Plays");
                });
#pragma warning restore 612, 618
        }
    }
}
