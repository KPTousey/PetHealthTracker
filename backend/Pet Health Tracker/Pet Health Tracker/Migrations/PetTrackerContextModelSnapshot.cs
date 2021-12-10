﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pet_Health_Tracker;

namespace Pet_Health_Tracker.Migrations
{
    [DbContext(typeof(PetTrackerContext))]
    partial class PetTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            ApptDateTime = new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(2613),
                            Caregiver = "Dr Doolittle",
                            Description = "Annual Checkup",
                            EmailAddress = "brewster@gmail.com",
                            Notes = "Check lump on ribs, bring in stool sample",
                            PetId = 1
                        },
                        new
                        {
                            Id = 2,
                            ApptDateTime = new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(4326),
                            Caregiver = "Pet Smart Grooming",
                            Description = "Hair Trim and Bath, Toenail trim",
                            EmailAddress = "princesstrudy@gmail.com",
                            Notes = "Full spa treatment",
                            PetId = 2
                        });
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.AuthorizedUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuthorizedUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "password",
                            Username = "username"
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

                    b.ToTable("MedicalItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Rabies",
                            ItemType = 0,
                            MedicalRecordId = 1,
                            TreatedOn = new DateTime(2021, 12, 10, 11, 5, 50, 123, DateTimeKind.Local).AddTicks(6992)
                        },
                        new
                        {
                            Id = 2,
                            Description = "Removed tumor in foot",
                            ItemType = 1,
                            MedicalRecordId = 3,
                            TreatedOn = new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8682)
                        },
                        new
                        {
                            Id = 3,
                            Description = "Flea and tic",
                            ItemType = 2,
                            MedicalRecordId = 2,
                            TreatedOn = new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8726)
                        },
                        new
                        {
                            Id = 4,
                            Description = "Male neuter",
                            ItemType = 3,
                            MedicalRecordId = 1,
                            TreatedOn = new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8731)
                        },
                        new
                        {
                            Id = 5,
                            Description = "Tests found allergies to: Chicken, Pork, Egg, Turkey, Grains, Peas",
                            ItemType = 4,
                            MedicalRecordId = 2,
                            TreatedOn = new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8734)
                        },
                        new
                        {
                            Id = 6,
                            Description = "Hydrocortisone",
                            ItemType = 5,
                            MedicalRecordId = 3,
                            TreatedOn = new DateTime(2021, 12, 10, 11, 5, 50, 126, DateTimeKind.Local).AddTicks(8738)
                        });
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.MedicalRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clinic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryVet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PetId")
                        .IsUnique();

                    b.ToTable("MedicalRecords");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Bedford",
                            Clinic = "Bedford Animal Hospital",
                            PetId = 1,
                            Phone = "440-555-1298",
                            PrimaryVet = "Dr. Doolittle",
                            State = "OH",
                            Street = "412 Oak Ln",
                            Zip = "44123"
                        },
                        new
                        {
                            Id = 2,
                            City = "Cleveland",
                            Clinic = "Gateway Animal Hospital",
                            PetId = 2,
                            Phone = "216-555-6728",
                            PrimaryVet = "Dr. Bob",
                            State = "OH",
                            Street = "Abbey Ave",
                            Zip = "44102"
                        },
                        new
                        {
                            Id = 3,
                            City = "Maple Heights",
                            Clinic = "Suburban Veterinarian Clinic",
                            PetId = 3,
                            Phone = "330-555-7263",
                            PrimaryVet = "Dr. Scott",
                            State = "OH",
                            Street = "58 Maple St",
                            Zip = "44242"
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
                            FirstName = "First",
                            LastName = "Last"
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
                            OwnerId = 1,
                            Photo = "",
                            Species = "Dog"
                        },
                        new
                        {
                            Id = 3,
                            Age = 2,
                            Breed = "Black Lab",
                            Gender = "Male",
                            Name = "Slim Jim",
                            OwnerId = 1,
                            Photo = "",
                            Species = "Dog"
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

                    b.ToTable("Weights");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CurrentWeight = 50,
                            Date = new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(549),
                            PetId = 1
                        },
                        new
                        {
                            Id = 2,
                            CurrentWeight = 12,
                            Date = new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(1297),
                            PetId = 2
                        },
                        new
                        {
                            Id = 3,
                            CurrentWeight = 2,
                            Date = new DateTime(2021, 12, 10, 11, 5, 50, 127, DateTimeKind.Local).AddTicks(1312),
                            PetId = 3
                        });
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.Appointment", b =>
                {
                    b.HasOne("Pet_Health_Tracker.Models.Pet", "Pet")
                        .WithMany("Appointments")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.MedicalItem", b =>
                {
                    b.HasOne("Pet_Health_Tracker.Models.MedicalRecord", "MedicalRecord")
                        .WithMany("MedicalItems")
                        .HasForeignKey("MedicalRecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MedicalRecord");
                });

            modelBuilder.Entity("Pet_Health_Tracker.Models.MedicalRecord", b =>
                {
                    b.HasOne("Pet_Health_Tracker.Models.Pet", "Pet")
                        .WithOne("MedicalRecord")
                        .HasForeignKey("Pet_Health_Tracker.Models.MedicalRecord", "PetId")
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
                        .WithMany("Weights")
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

            modelBuilder.Entity("Pet_Health_Tracker.Models.Pet", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("MedicalRecord");

                    b.Navigation("Weights");
                });
#pragma warning restore 612, 618
        }
    }
}
