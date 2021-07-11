﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Repository;

namespace WebApp.Migrations
{
    [DbContext(typeof(DataDBContext))]
    [Migration("20210711142203_Drezga")]
    partial class Drezga
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApp.Models.Call", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hazard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IncidentId")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IncidentId");

                    b.HasIndex("StreetId");

                    b.ToTable("Calls");
                });

            modelBuilder.Entity("WebApp.Models.Consumer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StreetId");

                    b.ToTable("Consumers");
                });

            modelBuilder.Entity("WebApp.Models.Crew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Crews");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "Profesional"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CoordX")
                        .HasColumnType("float");

                    b.Property<double>("CoordY")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StreetId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            CoordX = 9.8000000000000007,
                            CoordY = 9.8000000000000007,
                            Name = "Bla",
                            Type = "nesto"
                        });
                });

            modelBuilder.Entity("WebApp.Models.HistoricChange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SafetyDocId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkOrderId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SafetyDocId");

                    b.HasIndex("WorkOrderId");

                    b.HasIndex("WorkPlanId");

                    b.ToTable("HistoricChanges");
                });

            modelBuilder.Entity("WebApp.Models.Incident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ATA")
                        .HasColumnType("datetime2");

                    b.Property<int>("AffectedCustomers")
                        .HasColumnType("int");

                    b.Property<string>("Cause")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ConstructionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CrewId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ETA")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ETR")
                        .HasColumnType("datetime2");

                    b.Property<string>("Material")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ScheduledTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subcause")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Voltage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CrewId");

                    b.ToTable("Incidents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ATA = new DateTime(2021, 7, 11, 16, 22, 2, 445, DateTimeKind.Local).AddTicks(9991),
                            AffectedCustomers = 2,
                            Cause = "bla",
                            Confirmed = true,
                            ConstructionType = "bla",
                            ETA = new DateTime(2021, 7, 11, 16, 22, 2, 443, DateTimeKind.Local).AddTicks(5200),
                            ETR = new DateTime(2021, 7, 11, 16, 22, 2, 446, DateTimeKind.Local).AddTicks(643),
                            Material = "bla",
                            ScheduledTime = new DateTime(2021, 7, 11, 16, 22, 2, 446, DateTimeKind.Local).AddTicks(3170),
                            Status = "ok",
                            Subcause = "bla",
                            Type = "bla",
                            Voltage = 220.0
                        });
                });

            modelBuilder.Entity("WebApp.Models.Instruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeviceId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("WorkPlanId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("WebApp.Models.NClasses.IncidentDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int?>("IncidentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("IncidentId");

                    b.ToTable("IncidentsDevices");
                });

            modelBuilder.Entity("WebApp.Models.NClasses.SafetyDocDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int?>("SafetyDocId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("SafetyDocId");

                    b.ToTable("SafetyDocsDevices");
                });

            modelBuilder.Entity("WebApp.Models.NClasses.WorkOrderDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkOrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("WorkOrderId");

                    b.ToTable("WorkOrdersDevices");
                });

            modelBuilder.Entity("WebApp.Models.NClasses.WorkPlanDevice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DeviceId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.HasIndex("WorkPlanId");

                    b.ToTable("WorkPlansDevices");
                });

            modelBuilder.Entity("WebApp.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Seen")
                        .HasColumnType("bit");

                    b.Property<int>("TargetID")
                        .HasColumnType("int");

                    b.Property<string>("TargetType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("WebApp.Models.SafetyDoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GroundingRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OperationsCompleted")
                        .HasColumnType("bit");

                    b.Property<bool>("Ready")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TagsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkPlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkPlanId");

                    b.ToTable("SafetyDocs");
                });

            modelBuilder.Entity("WebApp.Models.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Streets");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Name = "Pasterova",
                            Priority = 7
                        },
                        new
                        {
                            Id = 1,
                            Name = "Gagarinova",
                            Priority = 8
                        });
                });

            modelBuilder.Entity("WebApp.Models.WorkOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Emergency")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IncidentId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StreetId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IncidentId");

                    b.HasIndex("StreetId");

                    b.ToTable("WorkOrders");
                });

            modelBuilder.Entity("WebApp.Models.WorkPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CrewId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Purpose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkOrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CrewId");

                    b.HasIndex("WorkOrderId");

                    b.ToTable("WorkPlans");
                });

            modelBuilder.Entity("WebApp.Models.Call", b =>
                {
                    b.HasOne("WebApp.Models.Incident", null)
                        .WithMany("Calls")
                        .HasForeignKey("IncidentId");

                    b.HasOne("WebApp.Models.Street", "Street")
                        .WithMany("Calls")
                        .HasForeignKey("StreetId");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("WebApp.Models.Consumer", b =>
                {
                    b.HasOne("WebApp.Models.Street", "Street")
                        .WithMany("Consumers")
                        .HasForeignKey("StreetId");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("WebApp.Models.Device", b =>
                {
                    b.HasOne("WebApp.Models.Street", "Street")
                        .WithMany("Devices")
                        .HasForeignKey("StreetId");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("WebApp.Models.HistoricChange", b =>
                {
                    b.HasOne("WebApp.Models.SafetyDoc", null)
                        .WithMany("History")
                        .HasForeignKey("SafetyDocId");

                    b.HasOne("WebApp.Models.WorkOrder", null)
                        .WithMany("History")
                        .HasForeignKey("WorkOrderId");

                    b.HasOne("WebApp.Models.WorkPlan", null)
                        .WithMany("History")
                        .HasForeignKey("WorkPlanId");
                });

            modelBuilder.Entity("WebApp.Models.Incident", b =>
                {
                    b.HasOne("WebApp.Models.Crew", "Crew")
                        .WithMany()
                        .HasForeignKey("CrewId");

                    b.Navigation("Crew");
                });

            modelBuilder.Entity("WebApp.Models.Instruction", b =>
                {
                    b.HasOne("WebApp.Models.Device", "Device")
                        .WithMany("Instructions")
                        .HasForeignKey("DeviceId");

                    b.HasOne("WebApp.Models.WorkPlan", null)
                        .WithMany("Instructions")
                        .HasForeignKey("WorkPlanId");

                    b.Navigation("Device");
                });

            modelBuilder.Entity("WebApp.Models.NClasses.IncidentDevice", b =>
                {
                    b.HasOne("WebApp.Models.Device", "Device")
                        .WithMany("Incidents")
                        .HasForeignKey("DeviceId");

                    b.HasOne("WebApp.Models.Incident", "Incident")
                        .WithMany("Devices")
                        .HasForeignKey("IncidentId");

                    b.Navigation("Device");

                    b.Navigation("Incident");
                });

            modelBuilder.Entity("WebApp.Models.NClasses.SafetyDocDevice", b =>
                {
                    b.HasOne("WebApp.Models.Device", "Device")
                        .WithMany("SafetyDocs")
                        .HasForeignKey("DeviceId");

                    b.HasOne("WebApp.Models.SafetyDoc", "SafetyDoc")
                        .WithMany("Devices")
                        .HasForeignKey("SafetyDocId");

                    b.Navigation("Device");

                    b.Navigation("SafetyDoc");
                });

            modelBuilder.Entity("WebApp.Models.NClasses.WorkOrderDevice", b =>
                {
                    b.HasOne("WebApp.Models.Device", "Device")
                        .WithMany("WorkOrders")
                        .HasForeignKey("DeviceId");

                    b.HasOne("WebApp.Models.WorkOrder", "WorkOrder")
                        .WithMany("Devices")
                        .HasForeignKey("WorkOrderId");

                    b.Navigation("Device");

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("WebApp.Models.NClasses.WorkPlanDevice", b =>
                {
                    b.HasOne("WebApp.Models.Device", "Device")
                        .WithMany("WorkPlans")
                        .HasForeignKey("DeviceId");

                    b.HasOne("WebApp.Models.WorkPlan", "WorkPlan")
                        .WithMany("Devices")
                        .HasForeignKey("WorkPlanId");

                    b.Navigation("Device");

                    b.Navigation("WorkPlan");
                });

            modelBuilder.Entity("WebApp.Models.SafetyDoc", b =>
                {
                    b.HasOne("WebApp.Models.WorkPlan", "WorkPlan")
                        .WithMany("SafetyDocs")
                        .HasForeignKey("WorkPlanId");

                    b.Navigation("WorkPlan");
                });

            modelBuilder.Entity("WebApp.Models.WorkOrder", b =>
                {
                    b.HasOne("WebApp.Models.Incident", "Incident")
                        .WithMany("WorkOrders")
                        .HasForeignKey("IncidentId");

                    b.HasOne("WebApp.Models.Street", "Street")
                        .WithMany("WorkOrders")
                        .HasForeignKey("StreetId");

                    b.Navigation("Incident");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("WebApp.Models.WorkPlan", b =>
                {
                    b.HasOne("WebApp.Models.Crew", "Crew")
                        .WithMany()
                        .HasForeignKey("CrewId");

                    b.HasOne("WebApp.Models.WorkOrder", "WorkOrder")
                        .WithMany("WorkPlans")
                        .HasForeignKey("WorkOrderId");

                    b.Navigation("Crew");

                    b.Navigation("WorkOrder");
                });

            modelBuilder.Entity("WebApp.Models.Device", b =>
                {
                    b.Navigation("Incidents");

                    b.Navigation("Instructions");

                    b.Navigation("SafetyDocs");

                    b.Navigation("WorkOrders");

                    b.Navigation("WorkPlans");
                });

            modelBuilder.Entity("WebApp.Models.Incident", b =>
                {
                    b.Navigation("Calls");

                    b.Navigation("Devices");

                    b.Navigation("WorkOrders");
                });

            modelBuilder.Entity("WebApp.Models.SafetyDoc", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("History");
                });

            modelBuilder.Entity("WebApp.Models.Street", b =>
                {
                    b.Navigation("Calls");

                    b.Navigation("Consumers");

                    b.Navigation("Devices");

                    b.Navigation("WorkOrders");
                });

            modelBuilder.Entity("WebApp.Models.WorkOrder", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("History");

                    b.Navigation("WorkPlans");
                });

            modelBuilder.Entity("WebApp.Models.WorkPlan", b =>
                {
                    b.Navigation("Devices");

                    b.Navigation("History");

                    b.Navigation("Instructions");

                    b.Navigation("SafetyDocs");
                });
#pragma warning restore 612, 618
        }
    }
}
