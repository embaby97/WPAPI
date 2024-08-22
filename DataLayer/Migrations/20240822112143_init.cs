using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BankCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    ReferenceItemIds = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version2 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractDescriptionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDescriptionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialClearanceType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialClearanceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Government",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Government", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobsInEgypt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobsInEgypt", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PoliceDepartment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovernmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoliceDepartment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualification", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QualificationVsWPCode",
                columns: table => new
                {
                    WPCodeId = table.Column<int>(type: "int", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualificationVsWPCode", x => new { x.QualificationId, x.WPCodeId });
                });

            migrationBuilder.CreateTable(
                name: "ReferenceItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WPCode = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    BankCode = table.Column<int>(type: "int", nullable: false),
                    Duplicated = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SesonalPermits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EgyptianCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForeignCompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPaied = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SesonalPermits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermitAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovernmentId = table.Column<int>(type: "int", nullable: false),
                    PoliceDepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermitAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermitAddress_Government_GovernmentId",
                        column: x => x.GovernmentId,
                        principalTable: "Government",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermitAddress_PoliceDepartment_PoliceDepartmentId",
                        column: x => x.PoliceDepartmentId,
                        principalTable: "PoliceDepartment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemsPricing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WPCode = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Start = table.Column<DateTime>(type: "Date", nullable: false),
                    End = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsPricing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemsPricing_ReferenceItems_WPCode",
                        column: x => x.WPCode,
                        principalTable: "ReferenceItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "person",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NId = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false, computedColumnSql: "CASE \r\n                WHEN LEFT(NId, 1) IN ('3', '4')\r\n                    THEN CONVERT(datetime, '20' + SUBSTRING(NId, 2, 2) + '-' + SUBSTRING(NId, 4, 2) + '-' + SUBSTRING(NId, 6, 2), 120)\r\n                ELSE CONVERT(datetime, '19' + SUBSTRING(NId, 2, 2) + '-' + SUBSTRING(NId, 4, 2) + '-' + SUBSTRING(NId, 6, 2), 120)\r\n                END"),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovernmentId = table.Column<int>(type: "int", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QualificationChangeDate = table.Column<DateTime>(type: "Date", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    ReligionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_person_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_person_Government_GovernmentId",
                        column: x => x.GovernmentId,
                        principalTable: "Government",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_person_Religions_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Financiallylisted",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    PermitId = table.Column<int>(type: "int", nullable: false),
                    IntervalStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntervalEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinanciallyClear = table.Column<bool>(type: "bit", nullable: false),
                    IsertionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financiallylisted", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Financiallylisted_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passports",
                columns: table => new
                {
                    PassportNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passports", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Passports_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DocumentNumber = table.Column<int>(type: "int", nullable: false),
                    WorkPermitNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermitAddressId = table.Column<int>(type: "int", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false),
                    QualificationChangeDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndOfVacationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsertedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permit_Passports_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "Passports",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permit_PermitAddress_PermitAddressId",
                        column: x => x.PermitAddressId,
                        principalTable: "PermitAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permit_Qualification_QualificationId",
                        column: x => x.QualificationId,
                        principalTable: "Qualification",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrancheId = table.Column<int>(type: "int", nullable: false),
                    PermitId = table.Column<int>(type: "int", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: false),
                    JobInEgypt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    JobTypesId = table.Column<int>(type: "int", nullable: false, defaultValue: 750),
                    JobsInEgyptId = table.Column<int>(type: "int", nullable: false),
                    ContractDescriptionTypeId = table.Column<int>(type: "int", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    Disapproved = table.Column<bool>(type: "bit", nullable: false),
                    Urgent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Branches_BrancheId",
                        column: x => x.BrancheId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_JobTypes_JobTypesId",
                        column: x => x.JobTypesId,
                        principalTable: "JobTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Permit_PermitId",
                        column: x => x.PermitId,
                        principalTable: "Permit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Requests_ServiceTypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualificationChangeDate = table.Column<DateTime>(type: "Date", nullable: true),
                    QualificationId = table.Column<int>(type: "int", nullable: false),
                    InseartionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestStates_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestStates_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceIntervals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ItemsPricingString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false),
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceIntervals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceIntervals_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemsPricingId = table.Column<int>(type: "int", nullable: false),
                    ItemPrice = table.Column<double>(type: "float", nullable: false),
                    InvoiceIntervalsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_InvoiceIntervals_InvoiceIntervalsId",
                        column: x => x.InvoiceIntervalsId,
                        principalTable: "InvoiceIntervals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankCodes_ReferenceItemIds",
                table: "BankCodes",
                column: "ReferenceItemIds",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Financiallylisted_PersonId",
                table: "Financiallylisted",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_InvoiceIntervalsId",
                table: "InvoiceDetails",
                column: "InvoiceIntervalsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceIntervals_InvoiceId",
                table: "InvoiceIntervals",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_RequestId",
                table: "Invoices",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemsPricing_WPCode",
                table: "ItemsPricing",
                column: "WPCode");

            migrationBuilder.CreateIndex(
                name: "IX_Passports_PersonId",
                table: "Passports",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Permit_PassportNumber",
                table: "Permit",
                column: "PassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Permit_PermitAddressId",
                table: "Permit",
                column: "PermitAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Permit_QualificationId",
                table: "Permit",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_PermitAddress_GovernmentId",
                table: "PermitAddress",
                column: "GovernmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PermitAddress_PoliceDepartmentId",
                table: "PermitAddress",
                column: "PoliceDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_person_GenderId",
                table: "person",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_person_GovernmentId",
                table: "person",
                column: "GovernmentId");

            migrationBuilder.CreateIndex(
                name: "IX_person_ReligionId",
                table: "person",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceItems_WPCode",
                table: "ReferenceItems",
                column: "WPCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_BrancheId",
                table: "Requests",
                column: "BrancheId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CountryId",
                table: "Requests",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_JobTypesId",
                table: "Requests",
                column: "JobTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_PermitId",
                table: "Requests",
                column: "PermitId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_PersonId",
                table: "Requests",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ServiceTypeId",
                table: "Requests",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStates_RequestId",
                table: "RequestStates",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestStates_StateId",
                table: "RequestStates",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_Code",
                table: "ServiceTypes",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_States_StateCode",
                table: "States",
                column: "StateCode",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankCodes");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "ContractDescriptionTypes");

            migrationBuilder.DropTable(
                name: "FinancialClearanceType");

            migrationBuilder.DropTable(
                name: "Financiallylisted");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "ItemsPricing");

            migrationBuilder.DropTable(
                name: "JobsInEgypt");

            migrationBuilder.DropTable(
                name: "QualificationVsWPCode");

            migrationBuilder.DropTable(
                name: "RequestStates");

            migrationBuilder.DropTable(
                name: "SesonalPermits");

            migrationBuilder.DropTable(
                name: "InvoiceIntervals");

            migrationBuilder.DropTable(
                name: "ReferenceItems");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "JobTypes");

            migrationBuilder.DropTable(
                name: "Permit");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "Passports");

            migrationBuilder.DropTable(
                name: "PermitAddress");

            migrationBuilder.DropTable(
                name: "Qualification");

            migrationBuilder.DropTable(
                name: "person");

            migrationBuilder.DropTable(
                name: "PoliceDepartment");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Government");

            migrationBuilder.DropTable(
                name: "Religions");
        }
    }
}
