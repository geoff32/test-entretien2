// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopApi.Models;

namespace ShopApi.Migrations
{
    [DbContext(typeof(ShopDBContext))]
    partial class ShopDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopApi.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 509, DateTimeKind.Local).AddTicks(6538),
                            Email = "pierre@citeo.com"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 509, DateTimeKind.Local).AddTicks(7070),
                            Email = "paul@citeo.com"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 509, DateTimeKind.Local).AddTicks(7091),
                            Email = "jaque@citeo.com"
                        });
                });

            modelBuilder.Entity("ShopApi.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 509, DateTimeKind.Local).AddTicks(9506),
                            CustomerId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 510, DateTimeKind.Local).AddTicks(2),
                            CustomerId = 2
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 510, DateTimeKind.Local).AddTicks(26),
                            CustomerId = 3
                        });
                });

            modelBuilder.Entity("ShopApi.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 510, DateTimeKind.Local).AddTicks(1419),
                            OrderId = 1,
                            ProductId = 1,
                            Quantity = 10
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 510, DateTimeKind.Local).AddTicks(2654),
                            OrderId = 2,
                            ProductId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 510, DateTimeKind.Local).AddTicks(2718),
                            OrderId = 2,
                            ProductId = 3,
                            Quantity = 1
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 510, DateTimeKind.Local).AddTicks(2721),
                            OrderId = 3,
                            ProductId = 4,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("ShopApi.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 505, DateTimeKind.Local).AddTicks(6764),
                            Name = "IMac",
                            Price = 2500,
                            Stock = 10
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 508, DateTimeKind.Local).AddTicks(2408),
                            Name = "Iphone",
                            Price = 800,
                            Stock = 150
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 508, DateTimeKind.Local).AddTicks(2462),
                            Name = "Ipad",
                            Price = 500,
                            Stock = 88
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2020, 4, 6, 12, 13, 51, 508, DateTimeKind.Local).AddTicks(2467),
                            Name = "Casque Bose",
                            Price = 400,
                            Stock = 2
                        });
                });

            modelBuilder.Entity("ShopApi.Models.Order", b =>
                {
                    b.HasOne("ShopApi.Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("FK_Order_Customer")
                        .IsRequired();
                });

            modelBuilder.Entity("ShopApi.Models.OrderItem", b =>
                {
                    b.HasOne("ShopApi.Models.Order", "Order")
                        .WithMany("OrderItem")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK_OrderItem_Order")
                        .IsRequired();

                    b.HasOne("ShopApi.Models.Product", "Product")
                        .WithMany("OrderItem")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK_OrderItem_Product")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
