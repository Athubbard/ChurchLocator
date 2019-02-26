﻿// <auto-generated />
using System;
using ChurchLocator.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChurchLocator.Migrations
{
    [DbContext(typeof(ChurchDbContext))]
    [Migration("20190226001444_User")]
    partial class User
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChurchLocator.Models.Church", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DenominationID");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("DenominationID");

                    b.ToTable("Churches");
                });

            modelBuilder.Entity("ChurchLocator.Models.Denomination", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Denominations");
                });

            modelBuilder.Entity("ChurchLocator.Models.Preference", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ChurchID");

                    b.Property<int?>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("ChurchID");

                    b.HasIndex("UserID");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("ChurchLocator.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmPassword");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ChurchLocator.Models.Church", b =>
                {
                    b.HasOne("ChurchLocator.Models.Denomination", "Denomination")
                        .WithMany()
                        .HasForeignKey("DenominationID");
                });

            modelBuilder.Entity("ChurchLocator.Models.Preference", b =>
                {
                    b.HasOne("ChurchLocator.Models.Church", "Church")
                        .WithMany()
                        .HasForeignKey("ChurchID");

                    b.HasOne("ChurchLocator.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });
#pragma warning restore 612, 618
        }
    }
}
