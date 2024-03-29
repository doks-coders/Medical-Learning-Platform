﻿// <auto-generated />
using System;
using MedicalSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MedicalSystem.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240109184800_AddedNewFeatures")]
    partial class AddedNewFeatures
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MedicalSystem.Models.Models.AssignmentFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FileUrl")
                        .HasColumnType("int");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("AssignmentFiles");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Study of the structure and organization of the body and its parts, including organs and tissues.",
                            Name = "Anatomy"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Exploration of the chemical processes and substances that occur within living organisms.",
                            Name = "Biochemistry"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Investigation of the nature and causes of diseases, including the examination of tissues, organs, and bodily fluids.",
                            Name = "Pathology"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Study of drugs and their interactions with living organisms, including their mechanisms of action and therapeutic uses.",
                            Name = "Pharmacology"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Development of practical abilities and techniques essential for healthcare professionals, including patient examination and communication.",
                            Name = "Clinical Skills"
                        });
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateUploaded")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Anatomy",
                            DateUploaded = new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8369),
                            ExamName = "MED Anatomy 101",
                            Year = 2024
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Biochemistry",
                            DateUploaded = new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8391),
                            ExamName = "Med Biochem Exam",
                            Year = 2024
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Pathology",
                            DateUploaded = new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8397),
                            ExamName = "Pathology Board Exam",
                            Year = 2024
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Pharmacology",
                            DateUploaded = new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8402),
                            ExamName = "Pharmaceutical Licensing Exam",
                            Year = 2024
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "Clinical Skills",
                            DateUploaded = new DateTime(2024, 1, 9, 19, 47, 58, 91, DateTimeKind.Local).AddTicks(8407),
                            ExamName = "Clinical Skills Assessment",
                            Year = 2024
                        });
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.ExamFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<string>("FileUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("ExamFiles");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.NoteFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FileUrl")
                        .HasColumnType("int");

                    b.Property<int>("TopicId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("NoteFiles");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateUploaded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LectureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.AssignmentFile", b =>
                {
                    b.HasOne("MedicalSystem.Models.Models.Topic", "Topic")
                        .WithMany("AssignmentFiles")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.ExamFile", b =>
                {
                    b.HasOne("MedicalSystem.Models.Models.Exam", "Exam")
                        .WithMany("ExamFiles")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.NoteFile", b =>
                {
                    b.HasOne("MedicalSystem.Models.Models.Topic", "Topic")
                        .WithMany("NoteFiles")
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.Topic", b =>
                {
                    b.HasOne("MedicalSystem.Models.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.Exam", b =>
                {
                    b.Navigation("ExamFiles");
                });

            modelBuilder.Entity("MedicalSystem.Models.Models.Topic", b =>
                {
                    b.Navigation("AssignmentFiles");

                    b.Navigation("NoteFiles");
                });
#pragma warning restore 612, 618
        }
    }
}
