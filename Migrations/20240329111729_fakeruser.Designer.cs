﻿// <auto-generated />
using System;
using DershaneOrnekSB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DershaneOrnekSB.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240329111729_fakeruser")]
    partial class fakeruser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DershaneOrnekSB.Entities.Choice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ExamId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.QuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("SelectedChoiceId")
                        .HasColumnType("int");

                    b.Property<int?>("UserExamAttemptId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserExamAttemptId");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("UserGuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 3, 29, 14, 17, 29, 398, DateTimeKind.Local).AddTicks(8037),
                            Email = "admin@test.com",
                            IsActive = true,
                            IsAdmin = true,
                            Name = "Admin",
                            Password = "123"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 3, 29, 14, 17, 29, 398, DateTimeKind.Local).AddTicks(8055),
                            Email = "hakki@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "Hakki",
                            Password = "123"
                        });
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.UserExamAssignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AssignmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserExamAssignments");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.UserExamAttempt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserExamAssignmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserExamAttempts");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Choice", b =>
                {
                    b.HasOne("DershaneOrnekSB.Entities.Question", null)
                        .WithMany("Choices")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Question", b =>
                {
                    b.HasOne("DershaneOrnekSB.Entities.Exam", null)
                        .WithMany("Questions")
                        .HasForeignKey("ExamId");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.QuestionAnswer", b =>
                {
                    b.HasOne("DershaneOrnekSB.Entities.UserExamAttempt", null)
                        .WithMany("Answers")
                        .HasForeignKey("UserExamAttemptId");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Exam", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Question", b =>
                {
                    b.Navigation("Choices");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.UserExamAttempt", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
