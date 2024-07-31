﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Platform.Persistence.Contexts;

#nullable disable

namespace Platform.Persistence.Migrations
{
    [DbContext(typeof(PlatformDbContext))]
    [Migration("20240427144403_mig_1")]
    partial class mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanyCompanyFile", b =>
                {
                    b.Property<Guid>("CompaniesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyFilesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CompaniesId", "CompanyFilesId");

                    b.HasIndex("CompanyFilesId");

                    b.ToTable("CompanyCompanyFile");
                });

            modelBuilder.Entity("GModuleGModuleFile", b =>
                {
                    b.Property<Guid>("GModuleFilesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GModulesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GModuleFilesId", "GModulesId");

                    b.HasIndex("GModulesId");

                    b.ToTable("GModuleGModuleFile");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdminUserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminUserFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorizedFullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BaseDbName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaxNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MersisNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialSecurityNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxOffice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TradeRegisterNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UrlPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WebAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BaseDbName", "UrlPath")
                        .IsUnique();

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.GModule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LogoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("GModules");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e1e374dc-9219-40b7-bedc-f2bab28c7df2"),
                            CreatedBy = "System Configuration",
                            CreatedDate = new DateTime(2024, 4, 27, 17, 44, 2, 591, DateTimeKind.Local).AddTicks(48),
                            IsDeleted = false,
                            Name = "GControl"
                        },
                        new
                        {
                            Id = new Guid("46839255-7b40-40b8-8c38-5025ed649dd9"),
                            CreatedBy = "System Configuration",
                            CreatedDate = new DateTime(2024, 4, 27, 17, 44, 2, 591, DateTimeKind.Local).AddTicks(58),
                            IsDeleted = false,
                            Name = "GCard"
                        },
                        new
                        {
                            Id = new Guid("f7e38ca2-5a9e-409e-85f3-29df12e11fa4"),
                            CreatedBy = "System Configuration",
                            CreatedDate = new DateTime(2024, 4, 27, 17, 44, 2, 591, DateTimeKind.Local).AddTicks(59),
                            IsDeleted = false,
                            Name = "GHr"
                        },
                        new
                        {
                            Id = new Guid("92d8876c-cef0-487c-8d0a-28c1dc3ad541"),
                            CreatedBy = "System Configuration",
                            CreatedDate = new DateTime(2024, 4, 27, 17, 44, 2, 591, DateTimeKind.Local).AddTicks(59),
                            IsDeleted = false,
                            Name = "GCrm"
                        });
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.GModuleLicenseTypePrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ACompanyPriceForAMonth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AUserPriceForAMonth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GModuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("LicenseTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TaxRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GModuleId");

                    b.HasIndex("LicenseTypeId");

                    b.ToTable("GModuleLicenseTypePrices");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.License", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GModuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("LicenseKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LicenseTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalCompanyNumber")
                        .HasColumnType("int");

                    b.Property<int>("TotalUserNumber")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("GModuleId");

                    b.HasIndex("LicenseTypeId");

                    b.ToTable("Licenses");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.LicenseDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("LicenseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LicenseStatus")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<Guid?>("SpecialOfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TaxRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LicenseId");

                    b.ToTable("LicenseDetails");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.LicenseType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CompanyNumber")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UsageMounth")
                        .HasColumnType("int");

                    b.Property<int>("UserNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("LicenseTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("949994a6-a6f2-4246-8ebf-cba6c993049c"),
                            CompanyNumber = 1,
                            CreatedBy = "System Configuration",
                            CreatedDate = new DateTime(2024, 4, 27, 17, 44, 2, 591, DateTimeKind.Local).AddTicks(122),
                            IsDeleted = false,
                            Name = "Deneme 1 ay",
                            UsageMounth = 1,
                            UserNumber = 1
                        },
                        new
                        {
                            Id = new Guid("f93893c2-f99c-4171-988e-6b72cb5fda06"),
                            CompanyNumber = 3,
                            CreatedBy = "System Configuration",
                            CreatedDate = new DateTime(2024, 4, 27, 17, 44, 2, 591, DateTimeKind.Local).AddTicks(124),
                            IsDeleted = false,
                            Name = "1 Yıl",
                            UsageMounth = 12,
                            UserNumber = 3
                        },
                        new
                        {
                            Id = new Guid("eefc43dd-d9c0-4181-8c46-c0edf5ff099f"),
                            CompanyNumber = 3,
                            CreatedBy = "System Configuration",
                            CreatedDate = new DateTime(2024, 4, 27, 17, 44, 2, 591, DateTimeKind.Local).AddTicks(124),
                            IsDeleted = false,
                            Name = "2 Yıl",
                            UsageMounth = 24,
                            UserNumber = 3
                        },
                        new
                        {
                            Id = new Guid("22cd6743-f3be-4a0f-9b28-3265f5df5b80"),
                            CompanyNumber = 3,
                            CreatedBy = "System Configuration",
                            CreatedDate = new DateTime(2024, 4, 27, 17, 44, 2, 591, DateTimeKind.Local).AddTicks(125),
                            IsDeleted = false,
                            Name = "3 Yıl",
                            UsageMounth = 36,
                            UserNumber = 3
                        });
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.SpecialOffer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DiscountRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GModuleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("GModuleId");

                    b.ToTable("SpecialOffers");
                });

            modelBuilder.Entity("Utilities.Core.UtilityDomain.Entities.Files.AppFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Storage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppFiles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AppFile");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Utilities.Core.UtilityDomain.Entities.Identity.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Utilities.Core.UtilityDomain.Entities.Identity.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RefreshTokenEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.Files.CompanyFile", b =>
                {
                    b.HasBaseType("Utilities.Core.UtilityDomain.Entities.Files.AppFile");

                    b.HasDiscriminator().HasValue("CompanyFile");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.Files.GModuleFile", b =>
                {
                    b.HasBaseType("Utilities.Core.UtilityDomain.Entities.Files.AppFile");

                    b.HasDiscriminator().HasValue("GModuleFile");
                });

            modelBuilder.Entity("CompanyCompanyFile", b =>
                {
                    b.HasOne("Platform.Domain.Entities.Definitions.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Platform.Domain.Entities.Definitions.Files.CompanyFile", null)
                        .WithMany()
                        .HasForeignKey("CompanyFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GModuleGModuleFile", b =>
                {
                    b.HasOne("Platform.Domain.Entities.Definitions.Files.GModuleFile", null)
                        .WithMany()
                        .HasForeignKey("GModuleFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Platform.Domain.Entities.Definitions.GModule", null)
                        .WithMany()
                        .HasForeignKey("GModulesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Utilities.Core.UtilityDomain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Utilities.Core.UtilityDomain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Utilities.Core.UtilityDomain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Utilities.Core.UtilityDomain.Entities.Identity.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Utilities.Core.UtilityDomain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Utilities.Core.UtilityDomain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.GModuleLicenseTypePrice", b =>
                {
                    b.HasOne("Platform.Domain.Entities.Definitions.GModule", "GModule")
                        .WithMany("GModuleLicenseTypePrices")
                        .HasForeignKey("GModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Platform.Domain.Entities.Definitions.LicenseType", "LicenseType")
                        .WithMany("GModuleLicenseTypePrices")
                        .HasForeignKey("LicenseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GModule");

                    b.Navigation("LicenseType");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.License", b =>
                {
                    b.HasOne("Platform.Domain.Entities.Definitions.Company", "Company")
                        .WithMany("Licenses")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Platform.Domain.Entities.Definitions.GModule", "GModule")
                        .WithMany("Licenses")
                        .HasForeignKey("GModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Platform.Domain.Entities.Definitions.LicenseType", "LicenseType")
                        .WithMany("Licenses")
                        .HasForeignKey("LicenseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("GModule");

                    b.Navigation("LicenseType");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.LicenseDetail", b =>
                {
                    b.HasOne("Platform.Domain.Entities.Definitions.License", "License")
                        .WithMany("LicenseDetails")
                        .HasForeignKey("LicenseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("License");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.SpecialOffer", b =>
                {
                    b.HasOne("Platform.Domain.Entities.Definitions.Company", "Company")
                        .WithMany("SpecialOffers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Platform.Domain.Entities.Definitions.GModule", "GModule")
                        .WithMany("SpecialOffers")
                        .HasForeignKey("GModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("GModule");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.Company", b =>
                {
                    b.Navigation("Licenses");

                    b.Navigation("SpecialOffers");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.GModule", b =>
                {
                    b.Navigation("GModuleLicenseTypePrices");

                    b.Navigation("Licenses");

                    b.Navigation("SpecialOffers");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.License", b =>
                {
                    b.Navigation("LicenseDetails");
                });

            modelBuilder.Entity("Platform.Domain.Entities.Definitions.LicenseType", b =>
                {
                    b.Navigation("GModuleLicenseTypePrices");

                    b.Navigation("Licenses");
                });
#pragma warning restore 612, 618
        }
    }
}
