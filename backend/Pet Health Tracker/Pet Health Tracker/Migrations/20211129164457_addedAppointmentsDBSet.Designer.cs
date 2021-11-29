﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pet_Health_Tracker;

namespace Pet_Health_Tracker.Migrations
{
    [DbContext(typeof(PetTrackerContext))]
    [Migration("20211129164457_addedAppointmentsDBSet")]
    partial class addedAppointmentsDBSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pet_Health_Tracker.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApptDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Caregiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApptDateTime = new DateTime(2021, 11, 29, 11, 44, 56, 732, DateTimeKind.Local).AddTicks(9891),
                            Caregiver = "Dr Doolittle",
                            Description = "Annual Checkup",
                            EmailAddress = "brewster@gmail.com",
                            Notes = "Check lump on ribs, bring in stool sample",
                            PetId = 1
                        },
                        new
                        {
                            Id = 2,
                            ApptDateTime = new DateTime(2021, 11, 29, 11, 44, 56, 733, DateTimeKind.Local).AddTicks(1439),
                            Caregiver = "Pet Smart Grooming",
                            Description = "Hair Trim and Bath, Toenail trim",
                            EmailAddress = "princesstrudy@gmail.com",
                            Notes = "Full spa treatment",
                            PetId = 2
                        },
                        new
                        {
                            Id = 3,
                            ApptDateTime = new DateTime(2021, 11, 29, 11, 44, 56, 733, DateTimeKind.Local).AddTicks(1458),
                            Caregiver = "Exotic Vet Hospital",
                            Description = "Toenail Trim & tooth extraction",
                            EmailAddress = "slimjim@gmail.com",
                            Notes = "No food after midnight the night before",
                            PetId = 3
                        });
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.MedicalItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemType")
                        .HasColumnType("int");

                    b.Property<int>("MedicalRecordId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TreatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MedicalRecordId");

                    b.ToTable("MedicalItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna.",
                            ItemType = 0,
                            MedicalRecordId = 1,
                            TreatedOn = new DateTime(2021, 11, 29, 11, 44, 56, 728, DateTimeKind.Local).AddTicks(2113)
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna.",
                            ItemType = 1,
                            MedicalRecordId = 1,
                            TreatedOn = new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1576)
                        },
                        new
                        {
                            Id = 3,
                            Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna.",
                            ItemType = 2,
                            MedicalRecordId = 1,
                            TreatedOn = new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1657)
                        },
                        new
                        {
                            Id = 4,
                            Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna.",
                            ItemType = 3,
                            MedicalRecordId = 1,
                            TreatedOn = new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1663)
                        },
                        new
                        {
                            Id = 5,
                            Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna.",
                            ItemType = 4,
                            MedicalRecordId = 1,
                            TreatedOn = new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1666)
                        },
                        new
                        {
                            Id = 6,
                            Description = "Cras eu malesuada lectus. Suspendisse vel mattis magna.",
                            ItemType = 5,
                            MedicalRecordId = 1,
                            TreatedOn = new DateTime(2021, 11, 29, 11, 44, 56, 731, DateTimeKind.Local).AddTicks(1669)
                        });
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("MedicalRecords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PetId = 1
                        },
                        new
                        {
                            Id = 2,
                            PetId = 2
                        },
                        new
                        {
                            Id = 3,
                            PetId = 3
                        });
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Dan",
                            LastName = "Fairchild"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Kevin",
                            LastName = "Tousey"
                        });
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Species")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 7,
                            Breed = "Husky Mix",
                            Gender = "Male",
                            Name = "Brewster",
                            OwnerId = 1,
                            Photo = "",
                            Species = "Dog"
                        },
                        new
                        {
                            Id = 2,
                            Age = 6,
                            Breed = "Maltese",
                            Gender = "Female",
                            Name = "Princess Trudy",
                            OwnerId = 2,
                            Photo = "",
                            Species = "Dog"
                        },
                        new
                        {
                            Id = 3,
                            Age = 2,
                            Breed = "Black Sable",
                            Gender = "Male",
                            Name = "Slim Jim",
                            OwnerId = 1,
                            Photo = "",
                            Species = "Ferret"
                        });
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.Weight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentWeight")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PetId");

                    b.ToTable("Weight");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentWeight = 50,
                            Date = new DateTime(2021, 11, 29, 11, 44, 56, 732, DateTimeKind.Local).AddTicks(7360),
                            PetId = 1
                        },
                        new
                        {
                            Id = 2,
                            CurrentWeight = 12,
                            Date = new DateTime(2021, 11, 29, 11, 44, 56, 732, DateTimeKind.Local).AddTicks(7971),
                            PetId = 2
                        },
                        new
                        {
                            Id = 3,
                            CurrentWeight = 2,
                            Date = new DateTime(2021, 11, 29, 11, 44, 56, 732, DateTimeKind.Local).AddTicks(7982),
                            PetId = 3
                        });
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.Appointment", b =>
                {
                    b.HasOne("Pet_Health_Tracker.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.MedicalItem", b =>
                {
                    b.HasOne("Pet_Health_Tracker.Models.MedicalRecord", "Record")
                        .WithMany("MedicalItems")
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Record");
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.MedicalRecord", b =>
                {
                    b.HasOne("Pet_Health_Tracker.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.Pet", b =>
                {
                    b.HasOne("Pet_Health_Tracker.Models.Owner", "Owner")
                        .WithMany("Pets")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.Weight", b =>
                {
                    b.HasOne("Pet_Health_Tracker.Models.Pet", "Pet")
                        .WithMany()
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.MedicalRecord", b =>
                {
                    b.Navigation("MedicalItems");
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.Owner", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
