﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShippingApp.Data;

#nullable disable

namespace ShippingApp.Migrations
{
    [DbContext(typeof(shipmentAppDatabase))]
    [Migration("20230509070007_payment")]
    partial class payment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShippingApp.Models.CheckpointModel", b =>
                {
                    b.Property<Guid>("checkpointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("checkpointName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("latitude")
                        .HasColumnType("real");

                    b.Property<float>("longitude")
                        .HasColumnType("real");

                    b.HasKey("checkpointId");

                    b.ToTable("ShipmentCheckpoints");
                });

            modelBuilder.Entity("ShippingApp.Models.CheckpointsDistanceModel", b =>
                {
                    b.Property<Guid>("distancMapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("checkpoint1Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("checkpoint2Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("cost")
                        .HasColumnType("real");

                    b.Property<float>("distance")
                        .HasColumnType("real");

                    b.HasKey("distancMapId");

                    b.ToTable("CheckpointMappings");
                });

            modelBuilder.Entity("ShippingApp.Models.RouteCheckpointsModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("checkpointId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("index")
                        .HasColumnType("int");

                    b.Property<Guid>("routeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RouteCheckpoints");
                });

            modelBuilder.Entity("ShippingApp.Models.RouteModel", b =>
                {
                    b.Property<Guid>("routeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("checkpoint1Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("checkpoint2Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("routeId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("ShippingApp.Models.ShipmentModel", b =>
                {
                    b.Property<Guid>("shipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("cointainerTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("customerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("dateOfOrder")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("destination")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("lastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("origin")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("productTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("shipmentPrice")
                        .HasColumnType("real");

                    b.Property<Guid>("shipmentStatusId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("shipmentWeight")
                        .HasColumnType("real");

                    b.HasKey("shipmentId");

                    b.ToTable("Shipments");
                });

            modelBuilder.Entity("ShippingApp.Models.ShipmentPaymentMap", b =>
                {
                    b.Property<Guid>("mapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("shipmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("transactionRecordId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("mapId");

                    b.ToTable("shipmentPaymentMaps");
                });

            modelBuilder.Entity("ShippingApp.Models.ShipmentStatusModel", b =>
                {
                    b.Property<Guid>("shipmentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("currentLocation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("lastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("shipmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("shipmentStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("shipmentStatusId");

                    b.ToTable("ShipmentStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
