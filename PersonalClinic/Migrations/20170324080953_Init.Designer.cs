using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using PersonalClinic.Models;

namespace PersonalClinic.Migrations
{
    [DbContext(typeof(PersonalClinicContext))]
    [Migration("20170324080953_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PersonalClinic.Models.History", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Note");

                    b.Property<int>("PatientId");

                    b.HasKey("ID");

                    b.HasIndex("PatientId");

                    b.ToTable("History");
                });

            modelBuilder.Entity("PersonalClinic.Models.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Identifier");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("ID");

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("PersonalClinic.Models.History", b =>
                {
                    b.HasOne("PersonalClinic.Models.Patient")
                        .WithMany("Histories")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
