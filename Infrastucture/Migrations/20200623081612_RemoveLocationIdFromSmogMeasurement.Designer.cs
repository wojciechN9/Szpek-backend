﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Szpek.Infrastructure.Models.Context;

namespace Szpek.Infrastucture.Migrations
{
    [DbContext(typeof(SzpekContext))]
    [Migration("20200623081612_RemoveLocationIdFromSmogMeasurement")]
    partial class RemoveLocationIdFromSmogMeasurement
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Szpek.Core.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CountryCode")
                        .HasColumnType("varchar(2) CHARACTER SET utf8mb4")
                        .HasMaxLength(2);

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<double>("Longitude")
                        .HasColumnType("double");

                    b.Property<string>("PostCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Street")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Voivodeship")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("LocationId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Szpek.Core.Models.AirQualityLevel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("AirQuality")
                        .HasColumnType("int");

                    b.Property<decimal>("MaxValue")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("MinValue")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("ModificationDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("PollutionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AirQualityLevel");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AirQuality = 0,
                            MaxValue = 21m,
                            MinValue = 0m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 2L,
                            AirQuality = 1,
                            MaxValue = 61m,
                            MinValue = 21m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 3L,
                            AirQuality = 2,
                            MaxValue = 101m,
                            MinValue = 61m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 4L,
                            AirQuality = 3,
                            MaxValue = 141m,
                            MinValue = 101m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 5L,
                            AirQuality = 4,
                            MaxValue = 201m,
                            MinValue = 141m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 6L,
                            AirQuality = 5,
                            MaxValue = 3000m,
                            MinValue = 201m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 7L,
                            AirQuality = 0,
                            MaxValue = 13m,
                            MinValue = 0m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 8L,
                            AirQuality = 1,
                            MaxValue = 37m,
                            MinValue = 13m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 9L,
                            AirQuality = 2,
                            MaxValue = 61m,
                            MinValue = 37m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 10L,
                            AirQuality = 3,
                            MaxValue = 85m,
                            MinValue = 61m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 11L,
                            AirQuality = 4,
                            MaxValue = 121m,
                            MinValue = 85m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 12L,
                            AirQuality = 5,
                            MaxValue = 3000m,
                            MinValue = 121m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        });
                });

            modelBuilder.Entity("Szpek.Core.Models.Board", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Board");
                });

            modelBuilder.Entity("Szpek.Core.Models.Firmware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<DateTime>("ReleaseDateTimeUtc")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Firmware");
                });

            modelBuilder.Entity("Szpek.Core.Models.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<long>("SensorId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SensorId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Szpek.Core.Models.Measurement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<long>("SmogMeasurementId")
                        .HasColumnType("bigint");

                    b.Property<long?>("WeatherMeasurementId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("SmogMeasurementId")
                        .IsUnique();

                    b.HasIndex("WeatherMeasurementId")
                        .IsUnique();

                    b.ToTable("Measurement");
                });

            modelBuilder.Entity("Szpek.Core.Models.Sensor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int?>("BoardId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("varchar(45) CHARACTER SET utf8mb4")
                        .HasMaxLength(45);

                    b.Property<int?>("InstalledFirmwareId")
                        .HasColumnType("int");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("PublicKey")
                        .IsRequired()
                        .HasColumnType("varchar(2000) CHARACTER SET utf8mb4")
                        .HasMaxLength(2000);

                    b.Property<int?>("RecommendedFirmwareId")
                        .HasColumnType("int");

                    b.Property<long>("SensorOwnerId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("BoardId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("InstalledFirmwareId");

                    b.HasIndex("RecommendedFirmwareId");

                    b.HasIndex("SensorOwnerId");

                    b.ToTable("Sensor");
                });

            modelBuilder.Entity("Szpek.Core.Models.SensorLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeUtc")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Message")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("SensorId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SensorId");

                    b.ToTable("SensorLog");
                });

            modelBuilder.Entity("Szpek.Core.Models.SensorOwner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsCompany")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("SensorOwner");
                });

            modelBuilder.Entity("Szpek.Core.Models.SmogMeasurement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<int>("AirQuality")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("PeriodFrom")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("PeriodTo")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Pm10Quality")
                        .HasColumnType("int");

                    b.Property<double>("Pm10Value")
                        .HasColumnType("double");

                    b.Property<double>("Pm1Value")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("double")
                        .HasDefaultValue(0.0);

                    b.Property<int>("Pm25Quality")
                        .HasColumnType("int");

                    b.Property<double>("Pm25Value")
                        .HasColumnType("double");

                    b.Property<int>("SamplesQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SmogMeassurement");
                });

            modelBuilder.Entity("Szpek.Core.Models.WeatherMeasurement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<double>("AtmosphericPreassure")
                        .HasColumnType("double");

                    b.Property<double>("CelciusTemperature")
                        .HasColumnType("double");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<double>("HumidityPercentage")
                        .HasColumnType("double");

                    b.Property<DateTime>("MeasurementDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("WeatherMeasurement");
                });

            modelBuilder.Entity("Szpek.Core.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<long?>("SensorOwnerId")
                        .HasColumnType("bigint");

                    b.HasIndex("SensorOwnerId");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Szpek.Core.Models.Address", b =>
                {
                    b.HasOne("Szpek.Core.Models.Location", "Location")
                        .WithOne("Address")
                        .HasForeignKey("Szpek.Core.Models.Address", "LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Szpek.Core.Models.Location", b =>
                {
                    b.HasOne("Szpek.Core.Models.Sensor", "Sensor")
                        .WithMany("Locations")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Szpek.Core.Models.Measurement", b =>
                {
                    b.HasOne("Szpek.Core.Models.Location", "Location")
                        .WithMany("Meassurements")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Szpek.Core.Models.SmogMeasurement", "SmogMeasurement")
                        .WithOne("Measurement")
                        .HasForeignKey("Szpek.Core.Models.Measurement", "SmogMeasurementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Szpek.Core.Models.WeatherMeasurement", "WeatherMeasurement")
                        .WithOne("Measurement")
                        .HasForeignKey("Szpek.Core.Models.Measurement", "WeatherMeasurementId");
                });

            modelBuilder.Entity("Szpek.Core.Models.Sensor", b =>
                {
                    b.HasOne("Szpek.Core.Models.Board", "Board")
                        .WithMany()
                        .HasForeignKey("BoardId");

                    b.HasOne("Szpek.Core.Models.Firmware", "InstalledFirmware")
                        .WithMany()
                        .HasForeignKey("InstalledFirmwareId");

                    b.HasOne("Szpek.Core.Models.Firmware", "RecommendedFirmware")
                        .WithMany()
                        .HasForeignKey("RecommendedFirmwareId");

                    b.HasOne("Szpek.Core.Models.SensorOwner", "SensorOwner")
                        .WithMany("Sensors")
                        .HasForeignKey("SensorOwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Szpek.Core.Models.SensorLog", b =>
                {
                    b.HasOne("Szpek.Core.Models.Sensor", "Sensor")
                        .WithMany("Logs")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Szpek.Core.Models.User", b =>
                {
                    b.HasOne("Szpek.Core.Models.SensorOwner", "SensorOwner")
                        .WithMany()
                        .HasForeignKey("SensorOwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
