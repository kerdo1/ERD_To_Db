﻿// <auto-generated />
using System;
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    partial class DatabaseTaskDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Core.Domain.Access_Level", b =>
                {
                    b.Property<int>("Access_Level_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Access_Level_Id"), 1L, 1);

                    b.Property<string>("Access_Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("Access_Level_Id");

                    b.ToTable("AccessLevels");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Borrowed_Item", b =>
                {
                    b.Property<int>("Borrowed_Item_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Borrowed_Item_Id"), 1L, 1);

                    b.Property<DateTime>("Borrow_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<int>("Item_Name")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<DateTime>("Return_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Borrowed_Item_Id");

                    b.HasIndex("Employee_Id");

                    b.ToTable("BorrowedItems");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Branch_Office", b =>
                {
                    b.Property<int>("Branch_Office_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Branch_Office_Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Company_Id")
                        .HasColumnType("int");

                    b.Property<string>("Contact_Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Contact_Person")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Contact_Phonenumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Registry_Number")
                        .HasColumnType("int");

                    b.HasKey("Branch_Office_Id");

                    b.HasIndex("Company_Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Company", b =>
                {
                    b.Property<int>("Company_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Company_Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Contact_Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Contact_Person")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Contact_Phonenumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Registry_Number")
                        .HasColumnType("int");

                    b.HasKey("Company_Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Department", b =>
                {
                    b.Property<int>("Department_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Department_Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Branch_Office_Id")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Contact_Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Contact_Person")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Contact_Phonenumber")
                        .HasColumnType("int");

                    b.HasKey("Department_Id");

                    b.HasIndex("Branch_Office_Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employee_Id"), 1L, 1);

                    b.Property<int>("Access_Level_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("At_Work_Since")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("At_Work_Until")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Contact_Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Contact_Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Contact_Phonenumber")
                        .HasColumnType("int");

                    b.Property<int>("Department_Id")
                        .HasColumnType("int");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Personal_Idendification_Number")
                        .HasColumnType("int");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Employee_Id");

                    b.HasIndex("Access_Level_Id");

                    b.HasIndex("Department_Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employees_Child", b =>
                {
                    b.Property<int>("Employees_Child_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Employees_Child_Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Employees_Child_Id");

                    b.HasIndex("Employee_Id");

                    b.ToTable("Employees_Children");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Health_Check", b =>
                {
                    b.Property<int>("Health_Check_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Health_Check_Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DeDatescription")
                        .HasColumnType("datetime2");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Health_Check_Id");

                    b.HasIndex("Employee_Id");

                    b.ToTable("HealthChecks");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Hint", b =>
                {
                    b.Property<int>("HintId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HintId"), 1L, 1);

                    b.Property<bool>("Anonymous")
                        .HasColumnType("bit");

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("HintId");

                    b.ToTable("Hint");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Job_Title", b =>
                {
                    b.Property<int>("Job_TitleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Job_TitleId"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Salary_level")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Job_TitleId");

                    b.ToTable("JobTitle");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Request", b =>
                {
                    b.Property<int>("Request_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Request_Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<string>("Recipient")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Request_Id");

                    b.HasIndex("Employee_Id");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Sick_Leave", b =>
                {
                    b.Property<int>("Sick_Leave_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sick_Leave_Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Stard_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Sick_Leave_Id");

                    b.HasIndex("Employee_Id");

                    b.ToTable("SickLeave");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Vacation", b =>
                {
                    b.Property<int>("Vacation_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Vacation_Id"), 1L, 1);

                    b.Property<string>("Comment")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Stard_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Vacation_Id");

                    b.HasIndex("Employee_Id");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Work_time", b =>
                {
                    b.Property<int>("Work_TimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Work_TimeId"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ening_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Job_Title_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Starting_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Work_TimeId");

                    b.HasIndex("Employee_Id")
                        .IsUnique();

                    b.HasIndex("Job_Title_Id");

                    b.ToTable("WorkTime");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Borrowed_Item", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Borrowed_Items")
                        .HasForeignKey("Employee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Branch_Office", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Company", "Company")
                        .WithMany("Branch_Offices")
                        .HasForeignKey("Company_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Department", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Branch_Office", "Branch_Office")
                        .WithMany("Departments")
                        .HasForeignKey("Branch_Office_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch_Office");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Access_Level", "Access_Level")
                        .WithMany("Employees")
                        .HasForeignKey("Access_Level_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Core.Domain.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("Department_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Access_Level");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employees_Child", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Employees_Child")
                        .HasForeignKey("Employee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Health_Check", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Health_Checks")
                        .HasForeignKey("Employee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Request", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Requests")
                        .HasForeignKey("Employee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Sick_Leave", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Sick_Leaves")
                        .HasForeignKey("Employee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Vacation", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("Employee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Work_time", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithOne("Work_time")
                        .HasForeignKey("DatabaseTask.Core.Domain.Work_time", "Employee_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DatabaseTask.Core.Domain.Job_Title", "Job_Title")
                        .WithMany("Work_time")
                        .HasForeignKey("Job_Title_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Job_Title");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Access_Level", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Branch_Office", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Company", b =>
                {
                    b.Navigation("Branch_Offices");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.Navigation("Borrowed_Items");

                    b.Navigation("Employees_Child");

                    b.Navigation("Health_Checks");

                    b.Navigation("Requests");

                    b.Navigation("Sick_Leaves");

                    b.Navigation("Vacations");

                    b.Navigation("Work_time")
                        .IsRequired();
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Job_Title", b =>
                {
                    b.Navigation("Work_time");
                });
#pragma warning restore 612, 618
        }
    }
}