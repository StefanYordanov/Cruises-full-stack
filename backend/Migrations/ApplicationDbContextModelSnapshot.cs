﻿// <auto-generated />
using System;
using CruisesWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CruisesWebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CruisesWebApp.Data.DbModels.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookingDate");

                    b.Property<decimal>("Price");

                    b.Property<int>("ShipId");

                    b.HasKey("Id");

                    b.HasIndex("ShipId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("CruisesWebApp.Data.DbModels.SalesUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<string>("Currency");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SalesUnits");
                });

            modelBuilder.Entity("CruisesWebApp.Data.DbModels.Ship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("SalesUnitID");

                    b.HasKey("Id");

                    b.HasIndex("SalesUnitID");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("CruisesWebApp.Data.DbModels.Booking", b =>
                {
                    b.HasOne("CruisesWebApp.Data.DbModels.Ship", "Ship")
                        .WithMany("Bookings")
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CruisesWebApp.Data.DbModels.Ship", b =>
                {
                    b.HasOne("CruisesWebApp.Data.DbModels.SalesUnit", "SalesUnit")
                        .WithMany("Ships")
                        .HasForeignKey("SalesUnitID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}