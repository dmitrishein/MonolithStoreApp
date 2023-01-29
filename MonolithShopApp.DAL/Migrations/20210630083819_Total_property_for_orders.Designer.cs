﻿// <auto-generated />
using System;
using EdProject.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EdProject.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210630083819_Total_property_for_orders")]
    partial class Total_property_for_orders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthorEdition", b =>
                {
                    b.Property<long>("AuthorsId")
                        .HasColumnType("bigint");

                    b.Property<long>("EditionsId")
                        .HasColumnType("bigint");

                    b.HasKey("AuthorsId", "EditionsId");

                    b.HasIndex("EditionsId");

                    b.ToTable("AuthorInEditions");

                    b.HasData(
                        new
                        {
                            AuthorsId = 1L,
                            EditionsId = 1L
                        },
                        new
                        {
                            AuthorsId = 1L,
                            EditionsId = 2L
                        },
                        new
                        {
                            AuthorsId = 2L,
                            EditionsId = 3L
                        },
                        new
                        {
                            AuthorsId = 2L,
                            EditionsId = 4L
                        },
                        new
                        {
                            AuthorsId = 1L,
                            EditionsId = 5L
                        },
                        new
                        {
                            AuthorsId = 2L,
                            EditionsId = 5L
                        });
                });

            modelBuilder.Entity("EdProject.DAL.Entities.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2021, 6, 30, 11, 38, 18, 354, DateTimeKind.Local).AddTicks(3830),
                            IsRemoved = false,
                            Name = "William Shakespare"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2021, 6, 30, 11, 38, 18, 354, DateTimeKind.Local).AddTicks(4128),
                            IsRemoved = false,
                            Name = "Stephen King"
                        });
                });

            modelBuilder.Entity("EdProject.DAL.Entities.Edition", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2021, 6, 30, 11, 38, 18, 352, DateTimeKind.Local).AddTicks(47),
                            Currency = "USD",
                            Description = "Classic Printing Edition",
                            IsRemoved = false,
                            Price = 1444.9m,
                            Status = "Available",
                            Title = "Hamlet",
                            Type = "Book"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2021, 6, 30, 11, 38, 18, 354, DateTimeKind.Local).AddTicks(3182),
                            Currency = "USD",
                            Description = "Classic Printing Edition",
                            IsRemoved = false,
                            Price = 1200.9m,
                            Status = "Available",
                            Title = "Othello",
                            Type = "Book"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2021, 6, 30, 11, 38, 18, 354, DateTimeKind.Local).AddTicks(3220),
                            Currency = "USD",
                            Description = "Classic Printing Edition",
                            IsRemoved = false,
                            Price = 1300.9m,
                            Status = "Available",
                            Title = "Pet Graveyard",
                            Type = "Book"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2021, 6, 30, 11, 38, 18, 354, DateTimeKind.Local).AddTicks(3228),
                            Currency = "USD",
                            Description = "Classic Printing Edition",
                            IsRemoved = false,
                            Price = 1140.6m,
                            Status = "NotAvailable",
                            Title = "Confrontation",
                            Type = "Book"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2021, 6, 30, 11, 38, 18, 354, DateTimeKind.Local).AddTicks(3233),
                            Currency = "USD",
                            Description = "Featuring Willy Shakespare",
                            IsRemoved = false,
                            Price = 120.23m,
                            Status = "NotAvailable",
                            Title = "Something Weird",
                            Type = "Magazine"
                        });
                });

            modelBuilder.Entity("EdProject.DAL.Entities.OrderItem", b =>
                {
                    b.Property<long>("EditionId")
                        .HasColumnType("bigint");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<int>("ItemsCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("EditionId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("EdProject.DAL.Entities.Orders", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<long?>("PaymentId")
                        .HasColumnType("bigint");

                    b.Property<int>("StatusType")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,4)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId")
                        .IsUnique()
                        .HasFilter("[PaymentId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("EdProject.DAL.Entities.Payments", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("TransactionId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("EdProject.DAL.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("RefreshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("RefreshTokenExpiryTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("isRemoved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6fe103e6-5481-4af0-972e-23789f07f5dc",
                            Email = "adminex@sample.te",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINEX@SAMPLE.TE",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEAxWy7/hCVwGdEN56dpw5MtwtqlIXCLocqs7uMk7HO9TTQ/RUD1UwSDK4evuYKUkiA==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SecurityStamp = "f6f0ad32-0b7e-4044-93ee-b5bbdbb4e124",
                            TwoFactorEnabled = false,
                            UserName = "admin",
                            isRemoved = false
                        },
                        new
                        {
                            Id = 2L,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b1089c7c-29f9-46d6-887f-cc42a01c9155",
                            Email = "userex@sample.te",
                            EmailConfirmed = true,
                            FirstName = "Client",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USEREX@SAMPLE.TE",
                            NormalizedUserName = "CLIENT",
                            PasswordHash = "AQAAAAEAACcQAAAAELXmtq2HqYNMsuAuPgkfzLD7wenvm5Yzd7WRxW+VTXnJLMT+ZBeS9b7T6XlVtBiqnQ==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            SecurityStamp = "e4c0ad9e-ce4f-42ce-9a1a-2890a5e1941e",
                            TwoFactorEnabled = false,
                            UserName = "client",
                            isRemoved = false
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<long>", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ConcurrencyStamp = "1",
                            Name = "admin",
                            NormalizedName = "admin"
                        },
                        new
                        {
                            Id = 2L,
                            ConcurrencyStamp = "2",
                            Name = "client",
                            NormalizedName = "client"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            RoleId = 1L
                        },
                        new
                        {
                            UserId = 1L,
                            RoleId = 2L
                        },
                        new
                        {
                            UserId = 2L,
                            RoleId = 2L
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AuthorEdition", b =>
                {
                    b.HasOne("EdProject.DAL.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EdProject.DAL.Entities.Edition", null)
                        .WithMany()
                        .HasForeignKey("EditionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EdProject.DAL.Entities.OrderItem", b =>
                {
                    b.HasOne("EdProject.DAL.Entities.Edition", "Edition")
                        .WithMany("OrderItems")
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EdProject.DAL.Entities.Orders", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("EdProject.DAL.Entities.Orders", b =>
                {
                    b.HasOne("EdProject.DAL.Entities.Payments", "Payment")
                        .WithOne("Order")
                        .HasForeignKey("EdProject.DAL.Entities.Orders", "PaymentId");

                    b.HasOne("EdProject.DAL.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<long>", b =>
                {
                    b.HasOne("EdProject.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<long>", b =>
                {
                    b.HasOne("EdProject.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<long>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<long>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EdProject.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<long>", b =>
                {
                    b.HasOne("EdProject.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EdProject.DAL.Entities.Edition", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EdProject.DAL.Entities.Orders", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("EdProject.DAL.Entities.Payments", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("EdProject.DAL.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
