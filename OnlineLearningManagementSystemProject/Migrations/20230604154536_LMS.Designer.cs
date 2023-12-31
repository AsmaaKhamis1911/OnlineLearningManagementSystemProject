﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineLearningManagementSystemProject.Models;

#nullable disable

namespace OnlineLearningManagementSystemProject.Migrations
{
    [DbContext(typeof(LMSContext))]
    [Migration("20230604154536_LMS")]
    partial class LMS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Assignment", b =>
                {
                    b.Property<int>("AssignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AssignmentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AssignmentPath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("AssignmentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StaffID")
                        .HasColumnType("int");

                    b.HasKey("AssignmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StaffID");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<string>("CourseCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<int>("Lab")
                        .HasColumnType("int");

                    b.Property<int>("Lecture")
                        .HasColumnType("int");

                    b.Property<int>("Training")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Material", b =>
                {
                    b.Property<int>("MaterialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialID"), 1L, 1);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("MaterialDate")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaterialPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaterialType")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("MaterialID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StaffId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("StaffImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.StaffCourse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StaffId");

                    b.ToTable("StaffCourses");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnrollYear")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("StudentPicture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniversityID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.StudentCourse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.StudentFile", b =>
                {
                    b.Property<int>("StudentFileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentFileID"), 1L, 1);

                    b.Property<string>("StudentFileName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StudentFilePath")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("StudentFileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("StudentFileID");

                    b.HasIndex("StudentID");

                    b.ToTable("studentFiles");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Assignment", b =>
                {
                    b.HasOne("OnlineLearningManagementSystemProject.Models.StudentFile", "StudentFile")
                        .WithOne("Assignment")
                        .HasForeignKey("OnlineLearningManagementSystemProject.Models.Assignment", "AssignmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineLearningManagementSystemProject.Models.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineLearningManagementSystemProject.Models.Staff", "Staff")
                        .WithMany("Assignments")
                        .HasForeignKey("StaffID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Staff");

                    b.Navigation("StudentFile");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Material", b =>
                {
                    b.HasOne("OnlineLearningManagementSystemProject.Models.Course", "Course")
                        .WithMany("Materials")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineLearningManagementSystemProject.Models.Staff", "Staff")
                        .WithMany("Material")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.StaffCourse", b =>
                {
                    b.HasOne("OnlineLearningManagementSystemProject.Models.Course", "course")
                        .WithMany("staffcourses")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineLearningManagementSystemProject.Models.Staff", "Staff")
                        .WithMany("Staffcourses")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Staff");

                    b.Navigation("course");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.StudentCourse", b =>
                {
                    b.HasOne("OnlineLearningManagementSystemProject.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineLearningManagementSystemProject.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.StudentFile", b =>
                {
                    b.HasOne("OnlineLearningManagementSystemProject.Models.Student", "Student")
                        .WithMany("StudentFiles")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Course", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Materials");

                    b.Navigation("StudentCourses");

                    b.Navigation("staffcourses");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Staff", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Material");

                    b.Navigation("Staffcourses");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");

                    b.Navigation("StudentFiles");
                });

            modelBuilder.Entity("OnlineLearningManagementSystemProject.Models.StudentFile", b =>
                {
                    b.Navigation("Assignment")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
