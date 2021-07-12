﻿// <auto-generated />
using System;
using IoTDataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IoTDataAccess.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210711004052_11072021migrationVersion0")]
    partial class _11072021migrationVersion0
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("IoTEntities.Concrete.DailyLog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("EPCNO")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("DailyLogs");
                });

            modelBuilder.Entity("IoTEntities.Concrete.Device", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeviceAddress")
                        .HasColumnType("INTEGER");

                    b.Property<string>("DeviceIPAddres")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceMacAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceName")
                        .HasColumnType("TEXT");

                    b.Property<string>("DevicePortNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceTopic")
                        .HasColumnType("TEXT");

                    b.Property<int>("PersonId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("PersonId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("IoTEntities.Concrete.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TCNo")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("IoTEntities.Concrete.Tag", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EPCNO")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PersonID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VehicleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.HasIndex("VehicleId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("IoTEntities.Concrete.Vehicle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PersonID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("VehicleColor")
                        .HasColumnType("TEXT");

                    b.Property<string>("VehicleModelName")
                        .HasColumnType("TEXT");

                    b.Property<string>("VehicleModelYear")
                        .HasColumnType("TEXT");

                    b.Property<string>("VehiclePlaque")
                        .HasColumnType("TEXT");

                    b.Property<string>("VehicleType")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("PersonID");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("IoTEntities.Concrete.Device", b =>
                {
                    b.HasOne("IoTEntities.Concrete.Person", "Person")
                        .WithMany("Devices")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("IoTEntities.Concrete.Tag", b =>
                {
                    b.HasOne("IoTEntities.Concrete.Person", null)
                        .WithMany("Tags")
                        .HasForeignKey("PersonID");

                    b.HasOne("IoTEntities.Concrete.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("IoTEntities.Concrete.Vehicle", b =>
                {
                    b.HasOne("IoTEntities.Concrete.Person", "Person")
                        .WithMany("Vehicles")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("IoTEntities.Concrete.Person", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("Tags");

                    b.Navigation("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
