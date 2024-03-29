﻿// <auto-generated />
using System;
using ServiceCenterApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ServiceCenterApp.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220225091923_009")]
    partial class _009
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RepaifPhoneDB.Client", b =>
                {
                    b.Property<Guid>("ID_Client")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Series_Number_Passport")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Client");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("RepaifPhoneDB.Device", b =>
                {
                    b.Property<Guid>("ID_Device")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Serial_Number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Device");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("RepaifPhoneDB.Employee", b =>
                {
                    b.Property<string>("ID_Employee")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EmploymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FIO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID_Position")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PositionID_Position")
                        .HasColumnType("int");

                    b.Property<string>("Series_Number_Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Employee");

                    b.HasIndex("PositionID_Position");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID_Employee = "Gurrex",
                            Address = "Москва",
                            EmploymentDate = new DateTime(2022, 2, 25, 16, 19, 22, 787, DateTimeKind.Local).AddTicks(716),
                            FIO = "Тимоходцев Павел Евгеньевич",
                            ID_Position = 5,
                            Password = "GurrexPassword",
                            Phone_Number = "89512289628",
                            Series_Number_Password = "3219 008001"
                        });
                });

            modelBuilder.Entity("RepaifPhoneDB.Order", b =>
                {
                    b.Property<Guid>("ID_Order")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClientID_Client")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date_Order")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeviceID_Device")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeID_Employee")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ID_Client")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Device")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ID_Employee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID_Status")
                        .HasColumnType("int");

                    b.Property<int?>("Order_StatusID_Status")
                        .HasColumnType("int");

                    b.HasKey("ID_Order");

                    b.HasIndex("ClientID_Client");

                    b.HasIndex("DeviceID_Device");

                    b.HasIndex("EmployeeID_Employee");

                    b.HasIndex("Order_StatusID_Status");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RepaifPhoneDB.Order_Status", b =>
                {
                    b.Property<int>("ID_Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Status"), 1L, 1);

                    b.Property<string>("Name_Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Status");

                    b.ToTable("order_Statuses");

                    b.HasData(
                        new
                        {
                            ID_Status = 1,
                            Name_Status = "Заказ зарегестрирован"
                        },
                        new
                        {
                            ID_Status = 2,
                            Name_Status = "Заказ выполняется"
                        },
                        new
                        {
                            ID_Status = 3,
                            Name_Status = "Заказ выполнен"
                        },
                        new
                        {
                            ID_Status = 4,
                            Name_Status = "Заказ закрыт"
                        });
                });

            modelBuilder.Entity("RepaifPhoneDB.Performance", b =>
                {
                    b.Property<Guid>("ID_Performance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date_Performance")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description_Repair")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Detail_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Final_Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("OrderKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Work_Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID_Performance");

                    b.HasIndex("OrderKey")
                        .IsUnique();

                    b.ToTable("performances");
                });

            modelBuilder.Entity("RepaifPhoneDB.Position", b =>
                {
                    b.Property<int>("ID_Position")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Position"), 1L, 1);

                    b.Property<string>("Name_Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Position");

                    b.ToTable("positions");

                    b.HasData(
                        new
                        {
                            ID_Position = 1,
                            Name_Position = "Стажер"
                        },
                        new
                        {
                            ID_Position = 2,
                            Name_Position = "Мастер"
                        },
                        new
                        {
                            ID_Position = 3,
                            Name_Position = "Старший мастер"
                        },
                        new
                        {
                            ID_Position = 4,
                            Name_Position = "Менеджер"
                        },
                        new
                        {
                            ID_Position = 5,
                            Name_Position = "Директор"
                        });
                });

            modelBuilder.Entity("RepaifPhoneDB.Relationship", b =>
                {
                    b.Property<Guid>("ID_Performance")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ID_Detail")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PerformanceID_Performance")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("StockDetailsID_Detail")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID_Performance", "ID_Detail");

                    b.HasIndex("PerformanceID_Performance");

                    b.HasIndex("StockDetailsID_Detail");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("RepaifPhoneDB.StockDetails", b =>
                {
                    b.Property<Guid>("ID_Detail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Choise")
                        .HasColumnType("bit");

                    b.Property<decimal>("FullPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name_Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NeededQuantity")
                        .HasColumnType("int");

                    b.Property<int>("QuantityStock")
                        .HasColumnType("int");

                    b.Property<decimal>("Unit_Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID_Detail");

                    b.ToTable("stockDetails");
                });

            modelBuilder.Entity("RepaifPhoneDB.Employee", b =>
                {
                    b.HasOne("RepaifPhoneDB.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionID_Position");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("RepaifPhoneDB.Order", b =>
                {
                    b.HasOne("RepaifPhoneDB.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientID_Client");

                    b.HasOne("RepaifPhoneDB.Device", "Device")
                        .WithMany("Orders")
                        .HasForeignKey("DeviceID_Device");

                    b.HasOne("RepaifPhoneDB.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeID_Employee");

                    b.HasOne("RepaifPhoneDB.Order_Status", "Order_Status")
                        .WithMany("Orders")
                        .HasForeignKey("Order_StatusID_Status");

                    b.Navigation("Client");

                    b.Navigation("Device");

                    b.Navigation("Employee");

                    b.Navigation("Order_Status");
                });

            modelBuilder.Entity("RepaifPhoneDB.Performance", b =>
                {
                    b.HasOne("RepaifPhoneDB.Order", "Order")
                        .WithOne("Per")
                        .HasForeignKey("RepaifPhoneDB.Performance", "OrderKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RepaifPhoneDB.Relationship", b =>
                {
                    b.HasOne("RepaifPhoneDB.Performance", "Performance")
                        .WithMany()
                        .HasForeignKey("PerformanceID_Performance");

                    b.HasOne("RepaifPhoneDB.StockDetails", "StockDetails")
                        .WithMany()
                        .HasForeignKey("StockDetailsID_Detail");

                    b.Navigation("Performance");

                    b.Navigation("StockDetails");
                });

            modelBuilder.Entity("RepaifPhoneDB.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RepaifPhoneDB.Device", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RepaifPhoneDB.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RepaifPhoneDB.Order", b =>
                {
                    b.Navigation("Per");
                });

            modelBuilder.Entity("RepaifPhoneDB.Order_Status", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RepaifPhoneDB.Position", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
