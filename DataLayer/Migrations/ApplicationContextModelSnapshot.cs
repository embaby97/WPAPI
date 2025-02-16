﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataLayer.Models.BankCodes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ReferenceItemIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ReferenceItemIds")
                        .IsUnique();

                    b.ToTable("BankCodes");
                });

            modelBuilder.Entity("DataLayer.Models.Branches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Version2")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("DataLayer.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DataLayer.Models.ContractDescriptionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContractDescriptionTypes");
                });

            modelBuilder.Entity("DataLayer.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("DataLayer.Models.FinancialClearanceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FinancialClearanceType");
                });

            modelBuilder.Entity("DataLayer.Models.Financiallylisted", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("FinanciallyClear")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IntervalEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IntervalStartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("IsertionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PermitId")
                        .HasColumnType("int");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Financiallylisted");
                });

            modelBuilder.Entity("DataLayer.Models.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");
                });

            modelBuilder.Entity("DataLayer.Models.Government", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Government");
                });

            modelBuilder.Entity("DataLayer.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("InseartionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("QualificationChangeDate")
                        .HasColumnType("Date");

                    b.Property<int>("QualificationId")
                        .HasColumnType("int");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("RequestId")
                        .IsUnique();

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DataLayer.Models.InvoiceDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("InvoiceIntervalsId")
                        .HasColumnType("int");

                    b.Property<double>("ItemPrice")
                        .HasColumnType("float");

                    b.Property<int>("ItemsPricingId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceIntervalsId");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("DataLayer.Models.InvoiceIntervals", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("Date");

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<string>("ItemsPricingString")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("QualificationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceIntervals");
                });

            modelBuilder.Entity("DataLayer.Models.ItemsPricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("End")
                        .HasColumnType("Date");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("Start")
                        .HasColumnType("Date");

                    b.Property<int>("WPCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WPCode");

                    b.ToTable("ItemsPricing");
                });

            modelBuilder.Entity("DataLayer.Models.JobsInEgypt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobsInEgypt");
                });

            modelBuilder.Entity("DataLayer.Models.JobTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("JobTypes");
                });

            modelBuilder.Entity("DataLayer.Models.Passport", b =>
                {
                    b.Property<string>("PassportNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InsertedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PassportNumber");

                    b.HasIndex("PersonId");

                    b.ToTable("Passports");
                });

            modelBuilder.Entity("DataLayer.Models.Permit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DocumentNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndOfVacationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InsertedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PermitAddressId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("QualificationChangeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("QualificationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WorkPermitNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PassportNumber");

                    b.HasIndex("PermitAddressId");

                    b.HasIndex("QualificationId");

                    b.ToTable("Permit");
                });

            modelBuilder.Entity("DataLayer.Models.PermitAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernmentId")
                        .HasColumnType("int");

                    b.Property<int>("PoliceDepartmentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GovernmentId");

                    b.HasIndex("PoliceDepartmentId");

                    b.ToTable("PermitAddress");
                });

            modelBuilder.Entity("DataLayer.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("CASE \r\n                WHEN LEFT(NId, 1) IN ('3', '4')\r\n                    THEN CONVERT(datetime, '20' + SUBSTRING(NId, 2, 2) + '-' + SUBSTRING(NId, 4, 2) + '-' + SUBSTRING(NId, 6, 2), 120)\r\n                ELSE CONVERT(datetime, '19' + SUBSTRING(NId, 2, 2) + '-' + SUBSTRING(NId, 4, 2) + '-' + SUBSTRING(NId, 6, 2), 120)\r\n                END");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderId")
                        .HasColumnType("int");

                    b.Property<int?>("GovernmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NId")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("QualificationChangeDate")
                        .HasColumnType("Date");

                    b.Property<int>("ReligionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.HasIndex("GovernmentId");

                    b.HasIndex("ReligionId");

                    b.ToTable("person");
                });

            modelBuilder.Entity("DataLayer.Models.PoliceDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("GovernmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PoliceDepartment");
                });

            modelBuilder.Entity("DataLayer.Models.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Qualification");
                });

            modelBuilder.Entity("DataLayer.Models.QualificationVsWPCode", b =>
                {
                    b.Property<int>("QualificationId")
                        .HasColumnType("int");

                    b.Property<int>("WPCodeId")
                        .HasColumnType("int");

                    b.HasKey("QualificationId", "WPCodeId");

                    b.ToTable("QualificationVsWPCode");
                });

            modelBuilder.Entity("DataLayer.Models.ReferenceItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BankCode")
                        .HasColumnType("int");

                    b.Property<bool>("Duplicated")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("WPCode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WPCode")
                        .IsUnique();

                    b.ToTable("ReferenceItems");
                });

            modelBuilder.Entity("DataLayer.Models.Religions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Religions");
                });

            modelBuilder.Entity("DataLayer.Models.Request", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<int>("BrancheId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContractDescriptionTypeId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Disapproved")
                        .HasColumnType("bit");

                    b.Property<string>("JobInEgypt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobTypesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(750);

                    b.Property<int>("JobsInEgyptId")
                        .HasColumnType("int");

                    b.Property<int>("PermitId")
                        .HasColumnType("int");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ServiceTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Urgent")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BrancheId");

                    b.HasIndex("CountryId");

                    b.HasIndex("JobTypesId");

                    b.HasIndex("PermitId");

                    b.HasIndex("PersonId");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("DataLayer.Models.RequestStates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("RequestId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RequestId");

                    b.HasIndex("StateId");

                    b.ToTable("RequestStates");
                });

            modelBuilder.Entity("DataLayer.Models.ServiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("ServiceTypes");
                });

            modelBuilder.Entity("DataLayer.Models.SesonalPermits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EgyptianCompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ForeignCompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPaied")
                        .HasColumnType("bit");

                    b.Property<string>("ListNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SesonalPermits");
                });

            modelBuilder.Entity("DataLayer.Models.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("StateCode")
                        .IsUnique();

                    b.ToTable("States");
                });

            modelBuilder.Entity("DataLayer.Models.Financiallylisted", b =>
                {
                    b.HasOne("DataLayer.Models.Person", null)
                        .WithMany("financiallylisted")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLayer.Models.Invoice", b =>
                {
                    b.HasOne("DataLayer.Models.Request", "Request")
                        .WithOne("Invoice")
                        .HasForeignKey("DataLayer.Models.Invoice", "RequestId");

                    b.Navigation("Request");
                });

            modelBuilder.Entity("DataLayer.Models.InvoiceDetails", b =>
                {
                    b.HasOne("DataLayer.Models.InvoiceIntervals", null)
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceIntervalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLayer.Models.InvoiceIntervals", b =>
                {
                    b.HasOne("DataLayer.Models.Invoice", null)
                        .WithMany("InvoiceIntervals")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLayer.Models.ItemsPricing", b =>
                {
                    b.HasOne("DataLayer.Models.ReferenceItems", "ReferenceItems")
                        .WithMany("ItemsPricing")
                        .HasForeignKey("WPCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReferenceItems");
                });

            modelBuilder.Entity("DataLayer.Models.Passport", b =>
                {
                    b.HasOne("DataLayer.Models.Person", "Person")
                        .WithMany("Passports")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataLayer.Models.Permit", b =>
                {
                    b.HasOne("DataLayer.Models.Passport", "Passport")
                        .WithMany("Permits")
                        .HasForeignKey("PassportNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.PermitAddress", "PermitAddress")
                        .WithMany()
                        .HasForeignKey("PermitAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.Qualification", "Qualification")
                        .WithMany()
                        .HasForeignKey("QualificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Passport");

                    b.Navigation("PermitAddress");

                    b.Navigation("Qualification");
                });

            modelBuilder.Entity("DataLayer.Models.PermitAddress", b =>
                {
                    b.HasOne("DataLayer.Models.Government", "Government")
                        .WithMany()
                        .HasForeignKey("GovernmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.PoliceDepartment", "PoliceDepartment")
                        .WithMany()
                        .HasForeignKey("PoliceDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Government");

                    b.Navigation("PoliceDepartment");
                });

            modelBuilder.Entity("DataLayer.Models.Person", b =>
                {
                    b.HasOne("DataLayer.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.Government", "Government")
                        .WithMany()
                        .HasForeignKey("GovernmentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("DataLayer.Models.Religions", "Religion")
                        .WithMany()
                        .HasForeignKey("ReligionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");

                    b.Navigation("Government");

                    b.Navigation("Religion");
                });

            modelBuilder.Entity("DataLayer.Models.Request", b =>
                {
                    b.HasOne("DataLayer.Models.Branches", "Branche")
                        .WithMany()
                        .HasForeignKey("BrancheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.JobTypes", "JobTypes")
                        .WithMany()
                        .HasForeignKey("JobTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.Permit", "Permit")
                        .WithMany("Request")
                        .HasForeignKey("PermitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.Person", "Person")
                        .WithMany("Requests")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.ServiceType", "ServiceType")
                        .WithMany()
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Branche");

                    b.Navigation("Country");

                    b.Navigation("JobTypes");

                    b.Navigation("Permit");

                    b.Navigation("Person");

                    b.Navigation("ServiceType");
                });

            modelBuilder.Entity("DataLayer.Models.RequestStates", b =>
                {
                    b.HasOne("DataLayer.Models.Request", null)
                        .WithMany("RequestStates")
                        .HasForeignKey("RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.State", "State")
                        .WithMany("RequestStates")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("DataLayer.Models.Invoice", b =>
                {
                    b.Navigation("InvoiceIntervals");
                });

            modelBuilder.Entity("DataLayer.Models.InvoiceIntervals", b =>
                {
                    b.Navigation("InvoiceDetails");
                });

            modelBuilder.Entity("DataLayer.Models.Passport", b =>
                {
                    b.Navigation("Permits");
                });

            modelBuilder.Entity("DataLayer.Models.Permit", b =>
                {
                    b.Navigation("Request");
                });

            modelBuilder.Entity("DataLayer.Models.Person", b =>
                {
                    b.Navigation("Passports");

                    b.Navigation("Requests");

                    b.Navigation("financiallylisted");
                });

            modelBuilder.Entity("DataLayer.Models.ReferenceItems", b =>
                {
                    b.Navigation("ItemsPricing");
                });

            modelBuilder.Entity("DataLayer.Models.Request", b =>
                {
                    b.Navigation("Invoice")
                        .IsRequired();

                    b.Navigation("RequestStates");
                });

            modelBuilder.Entity("DataLayer.Models.State", b =>
                {
                    b.Navigation("RequestStates");
                });
#pragma warning restore 612, 618
        }
    }
}
