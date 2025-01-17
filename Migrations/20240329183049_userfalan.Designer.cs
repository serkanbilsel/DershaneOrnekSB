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
    [Migration("20240329183049_userfalan")]
    partial class userfalan
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DershaneOrnekSB.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTopMenu")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderNo")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Choice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Choices");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ExamId")
                        .HasColumnType("int");

                    b.Property<string>("Explanation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMultipleChoice")
                        .HasColumnType("bit");

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
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2365),
                            Email = "admin@test.com",
                            IsActive = true,
                            IsAdmin = true,
                            Name = "Admin",
                            Password = "123"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2381),
                            Email = "hakki@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "Hakki",
                            Password = "123"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2382),
                            Email = "user1@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User1",
                            Password = "123"
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2383),
                            Email = "user2@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User2",
                            Password = "123"
                        },
                        new
                        {
                            Id = 5,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2384),
                            Email = "user3@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User3",
                            Password = "123"
                        },
                        new
                        {
                            Id = 6,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2385),
                            Email = "user4@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User4",
                            Password = "123"
                        },
                        new
                        {
                            Id = 7,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2387),
                            Email = "user5@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User5",
                            Password = "123"
                        },
                        new
                        {
                            Id = 8,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2388),
                            Email = "user6@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User6",
                            Password = "123"
                        },
                        new
                        {
                            Id = 9,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2389),
                            Email = "user7@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User7",
                            Password = "123"
                        },
                        new
                        {
                            Id = 10,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2390),
                            Email = "user8@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User8",
                            Password = "123"
                        },
                        new
                        {
                            Id = 11,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2391),
                            Email = "user9@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User9",
                            Password = "123"
                        },
                        new
                        {
                            Id = 12,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2391),
                            Email = "user10@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User10",
                            Password = "123"
                        },
                        new
                        {
                            Id = 13,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2392),
                            Email = "user11@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User11",
                            Password = "123"
                        },
                        new
                        {
                            Id = 14,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2393),
                            Email = "user12@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User12",
                            Password = "123"
                        },
                        new
                        {
                            Id = 15,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2394),
                            Email = "user13@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User13",
                            Password = "123"
                        },
                        new
                        {
                            Id = 16,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2395),
                            Email = "user14@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User14",
                            Password = "123"
                        },
                        new
                        {
                            Id = 17,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2396),
                            Email = "user15@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User15",
                            Password = "123"
                        },
                        new
                        {
                            Id = 18,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2397),
                            Email = "user16@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User16",
                            Password = "123"
                        },
                        new
                        {
                            Id = 19,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2398),
                            Email = "user17@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User17",
                            Password = "123"
                        },
                        new
                        {
                            Id = 20,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2399),
                            Email = "user18@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User18",
                            Password = "123"
                        },
                        new
                        {
                            Id = 21,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2400),
                            Email = "user19@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User19",
                            Password = "123"
                        },
                        new
                        {
                            Id = 22,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2401),
                            Email = "user20@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User20",
                            Password = "123"
                        },
                        new
                        {
                            Id = 23,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2402),
                            Email = "user21@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User21",
                            Password = "123"
                        },
                        new
                        {
                            Id = 24,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2403),
                            Email = "user22@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User22",
                            Password = "123"
                        },
                        new
                        {
                            Id = 25,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2432),
                            Email = "user23@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User23",
                            Password = "123"
                        },
                        new
                        {
                            Id = 26,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2433),
                            Email = "user24@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User24",
                            Password = "123"
                        },
                        new
                        {
                            Id = 27,
                            CreateDate = new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2434),
                            Email = "user25@test.com",
                            IsActive = true,
                            IsAdmin = false,
                            Name = "User25",
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

                    b.HasIndex("ExamId");

                    b.HasIndex("UserId");

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

            modelBuilder.Entity("DershaneOrnekSB.Entities.Exam", b =>
                {
                    b.HasOne("DershaneOrnekSB.Entities.Category", "Category")
                        .WithMany("Exams")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
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

            modelBuilder.Entity("DershaneOrnekSB.Entities.UserExamAssignment", b =>
                {
                    b.HasOne("DershaneOrnekSB.Entities.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DershaneOrnekSB.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Category", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.Exam", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("DershaneOrnekSB.Entities.UserExamAttempt", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
