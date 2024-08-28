﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketApp.Infrastructure.Data;

#nullable disable

namespace TicketApp.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240806081112_changedDataTypes")]
    partial class changedDataTypes
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketApp.Core.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IDNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("accountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateRegistered")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.AccountType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("accountType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("accountId")
                        .HasColumnType("int");

                    b.Property<string>("bookingRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numOfTickets")
                        .HasColumnType("int");

                    b.Property<int>("paymentId")
                        .HasColumnType("int");

                    b.Property<int>("tripScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("amount")
                        .HasColumnType("real");

                    b.Property<string>("cardNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cvv")
                        .HasColumnType("int");

                    b.Property<DateTime>("expiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("arrivalTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departureTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tripGroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("stationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.Train", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberOfSeats")
                        .HasColumnType("int");

                    b.Property<int>("trainNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Trains");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("arrivalStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departureStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberOfStops")
                        .HasColumnType("int");

                    b.Property<int>("tripGroupId")
                        .HasColumnType("int");

                    b.Property<int>("tripPriceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.TripGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("group")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tripType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TripGroups");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.TripPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("tripPrice")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("TripPrices");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.TripSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberOfSeats")
                        .HasColumnType("int");

                    b.Property<int>("scheduleId")
                        .HasColumnType("int");

                    b.Property<int>("trainId")
                        .HasColumnType("int");

                    b.Property<int>("tripId")
                        .HasColumnType("int");

                    b.Property<int>("tripStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TripSchedules");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.TripStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("stationId")
                        .HasColumnType("int");

                    b.Property<int>("tripId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TripStations");
                });

            modelBuilder.Entity("TicketApp.Core.Entities.TripStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("maintDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("maintUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("statusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TripStatuses");
                });
#pragma warning restore 612, 618
        }
    }
}
