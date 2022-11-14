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
    [Migration("20190709094453_BetaVersion")]
    partial class BetaVersion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
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
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
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
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Szpek.Core.Models.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("CountryCode")
                        .HasMaxLength(2);

                    b.Property<double>("Latitude");

                    b.Property<long>("LocationId");

                    b.Property<double>("Longitude");

                    b.Property<string>("PostCode");

                    b.Property<string>("Street");

                    b.Property<string>("Voivodeship");

                    b.HasKey("Id");

                    b.HasIndex("LocationId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Szpek.Core.Models.AirQualityLevel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AirQuality");

                    b.Property<decimal>("MaxValue");

                    b.Property<decimal>("MinValue");

                    b.Property<DateTime>("ModificationDateTime");

                    b.Property<int>("PollutionType");

                    b.HasKey("Id");

                    b.ToTable("AirQualityLevel");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AirQuality = 1,
                            MaxValue = 21m,
                            MinValue = 0m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 2L,
                            AirQuality = 2,
                            MaxValue = 61m,
                            MinValue = 21m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 3L,
                            AirQuality = 3,
                            MaxValue = 101m,
                            MinValue = 61m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 4L,
                            AirQuality = 4,
                            MaxValue = 141m,
                            MinValue = 101m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 5L,
                            AirQuality = 5,
                            MaxValue = 201m,
                            MinValue = 141m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 6L,
                            AirQuality = 6,
                            MaxValue = 3000m,
                            MinValue = 201m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 0
                        },
                        new
                        {
                            Id = 7L,
                            AirQuality = 1,
                            MaxValue = 13m,
                            MinValue = 0m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 8L,
                            AirQuality = 2,
                            MaxValue = 37m,
                            MinValue = 13m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 9L,
                            AirQuality = 3,
                            MaxValue = 61m,
                            MinValue = 37m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 10L,
                            AirQuality = 4,
                            MaxValue = 85m,
                            MinValue = 61m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 11L,
                            AirQuality = 5,
                            MaxValue = 121m,
                            MinValue = 85m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        },
                        new
                        {
                            Id = 12L,
                            AirQuality = 6,
                            MaxValue = 3000m,
                            MinValue = 121m,
                            ModificationDateTime = new DateTime(2019, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PollutionType = 1
                        });
                });

            modelBuilder.Entity("Szpek.Core.Models.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<long>("SensorId");

                    b.HasKey("Id");

                    b.HasIndex("SensorId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Szpek.Core.Models.Meassurement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AirQuality");

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<long>("LocationId");

                    b.Property<DateTime>("PeriodFrom");

                    b.Property<DateTime>("PeriodTo");

                    b.Property<int>("Pm10Quality");

                    b.Property<double>("Pm10Value");

                    b.Property<int>("Pm25Quality");

                    b.Property<double>("Pm25Value");

                    b.Property<int>("SamplesQuantity");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Meassurement");
                });

            modelBuilder.Entity("Szpek.Core.Models.Sensor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(45);

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("PublicKey")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<long>("SensorOwnerId");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("SensorOwnerId");

                    b.ToTable("Sensor");
                });

            modelBuilder.Entity("Szpek.Core.Models.SensorOwner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<bool>("IsCompany");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SensorOwner");
                });

            modelBuilder.Entity("Szpek.Core.Models.User", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<long?>("SensorOwnerId");

                    b.HasDiscriminator().HasValue("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Szpek.Core.Models.Address", b =>
                {
                    b.HasOne("Szpek.Core.Models.Location", "Location")
                        .WithOne("Address")
                        .HasForeignKey("Szpek.Core.Models.Address", "LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Szpek.Core.Models.Location", b =>
                {
                    b.HasOne("Szpek.Core.Models.Sensor", "Sensor")
                        .WithMany("Locations")
                        .HasForeignKey("SensorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Szpek.Core.Models.Meassurement", b =>
                {
                    b.HasOne("Szpek.Core.Models.Location", "Location")
                        .WithMany("Meassurements")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Szpek.Core.Models.Sensor", b =>
                {
                    b.HasOne("Szpek.Core.Models.SensorOwner", "SensorOwner")
                        .WithMany("Sensors")
                        .HasForeignKey("SensorOwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
