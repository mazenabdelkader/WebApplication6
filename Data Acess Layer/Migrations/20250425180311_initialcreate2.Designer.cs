﻿// <auto-generated />
using System;
using Data_Acess_Layer.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data_Acess_Layer.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20250425180311_initialcreate2")]
    partial class initialcreate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data_Acess_Layer.models.DepartmentModel.Department", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 10L, 10);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<DateTime?>("createdon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("bit");

                    b.Property<int>("lastmodifiedby")
                        .HasColumnType("int");

                    b.Property<DateTime?>("lastmodifiedon")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.HasKey("id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("Data_Acess_Layer.models.EmployeeModel.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("HiringDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("LastModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<DateTime?>("createdon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int?>("departmentId")
                        .HasColumnType("int");

                    b.Property<int>("id")
                        .HasColumnType("int");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("bit");

                    b.Property<int>("lastmodifiedby")
                        .HasColumnType("int");

                    b.Property<DateTime?>("lastmodifiedon")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("Data_Acess_Layer.models.EmployeeModel.Employee", b =>
                {
                    b.HasOne("Data_Acess_Layer.models.DepartmentModel.Department", "department")
                        .WithMany()
                        .HasForeignKey("departmentId");

                    b.Navigation("department");
                });
#pragma warning restore 612, 618
        }
    }
}
