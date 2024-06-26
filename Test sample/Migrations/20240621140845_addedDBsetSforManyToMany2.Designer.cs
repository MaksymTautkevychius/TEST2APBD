﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test_sample.Data;

#nullable disable

namespace Test_sample.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20240621140845_addedDBsetSforManyToMany2")]
    partial class addedDBsetSforManyToMany2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test_sample.Models.Backpacks", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("ItemsId")
                        .HasColumnType("int");

                    b.Property<int>("amount")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "ItemsId");

                    b.HasIndex("ItemsId");

                    b.ToTable("BackpacksEnumerable");
                });

            modelBuilder.Entity("Test_sample.Models.Character", b =>
                {
                    b.Property<int>("CharactersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CharactersId"));

                    b.Property<int>("CurrentWeil")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MaxWeight")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("CharactersId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Test_sample.Models.Characters_Titles", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.Property<int>("TitlesId")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "TitlesId");

                    b.HasIndex("TitlesId");

                    b.ToTable("CharactersTitlesEnumerable");
                });

            modelBuilder.Entity("Test_sample.Models.Item", b =>
                {
                    b.Property<int>("ItemsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemsId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("ItemsId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Test_sample.Models.Title", b =>
                {
                    b.Property<int>("TitlesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TitlesId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Weight")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.HasKey("TitlesId");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("Test_sample.Models.Backpacks", b =>
                {
                    b.HasOne("Test_sample.Models.Character", "Character")
                        .WithMany("BackpacksCollection")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_sample.Models.Item", "Item")
                        .WithMany("BackpacksCollection")
                        .HasForeignKey("ItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("Test_sample.Models.Characters_Titles", b =>
                {
                    b.HasOne("Test_sample.Models.Character", "Character")
                        .WithMany("CharactersTitlesCollection")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test_sample.Models.Title", "Title")
                        .WithMany("CharactersTitlesCollection")
                        .HasForeignKey("TitlesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("Test_sample.Models.Character", b =>
                {
                    b.Navigation("BackpacksCollection");

                    b.Navigation("CharactersTitlesCollection");
                });

            modelBuilder.Entity("Test_sample.Models.Item", b =>
                {
                    b.Navigation("BackpacksCollection");
                });

            modelBuilder.Entity("Test_sample.Models.Title", b =>
                {
                    b.Navigation("CharactersTitlesCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
