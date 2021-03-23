using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clusters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clusters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AccessType = table.Column<byte>(type: "tinyint", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operations_Operations_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Username = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "varchar(64)", unicode: false, maxLength: 64, nullable: false),
                    NationalCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(254)", unicode: false, maxLength: 254, nullable: true),
                    CellPhoneNumber = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationsOfGroups",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OperationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsOfGroups", x => new { x.GroupId, x.OperationId });
                    table.ForeignKey(
                        name: "FK_OperationsOfGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OperationsOfGroups_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DateRanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateRanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DateRanges_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersOfGroups",
                columns: table => new
                {
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersOfGroups", x => new { x.GroupId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UsersOfGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersOfGroups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClusterCosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateRangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClusterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClusterIndicatorType = table.Column<byte>(type: "tinyint", nullable: false),
                    TargetValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RealValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PerformancePercent = table.Column<double>(type: "float", nullable: true),
                    RealizationPercent = table.Column<double>(type: "float", nullable: true),
                    DeviationPercent = table.Column<double>(type: "float", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClusterCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClusterCosts_Clusters_ClusterId",
                        column: x => x.ClusterId,
                        principalTable: "Clusters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClusterCosts_DateRanges_DateRangeId",
                        column: x => x.DateRangeId,
                        principalTable: "DateRanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HeadquarterCosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateRangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeadquarterIndicatorType = table.Column<byte>(type: "tinyint", nullable: false),
                    TargetValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RealValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PerformancePercent = table.Column<double>(type: "float", nullable: true),
                    RealizationPercent = table.Column<double>(type: "float", nullable: true),
                    DeviationPercent = table.Column<double>(type: "float", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadquarterCosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeadquarterCosts_DateRanges_DateRangeId",
                        column: x => x.DateRangeId,
                        principalTable: "DateRanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateRangeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClusterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<byte>(type: "tinyint", nullable: false),
                    FirstWeekTargetValue = table.Column<double>(type: "float", nullable: true),
                    FirstWeekRealValue = table.Column<double>(type: "float", nullable: true),
                    FirstWeekPerformancePercent = table.Column<double>(type: "float", nullable: true),
                    FirstWeekRealizationPercent = table.Column<double>(type: "float", nullable: true),
                    SecondWeekTargetValue = table.Column<double>(type: "float", nullable: true),
                    SecondWeekRealValue = table.Column<double>(type: "float", nullable: true),
                    SecondWeekPerformancePercent = table.Column<double>(type: "float", nullable: true),
                    SecondWeekRealizationPercent = table.Column<double>(type: "float", nullable: true),
                    ThirdWeekTargetValue = table.Column<double>(type: "float", nullable: true),
                    ThirdWeekRealValue = table.Column<double>(type: "float", nullable: true),
                    ThirdWeekPerformancePercent = table.Column<double>(type: "float", nullable: true),
                    ThirdWeekRealizationPercent = table.Column<double>(type: "float", nullable: true),
                    FourthWeekTargetValue = table.Column<double>(type: "float", nullable: true),
                    FourthWeekRealValue = table.Column<double>(type: "float", nullable: true),
                    FourthWeekPerformancePercent = table.Column<double>(type: "float", nullable: true),
                    FourthWeekRealizationPercent = table.Column<double>(type: "float", nullable: true),
                    MonthTargetValue = table.Column<double>(type: "float", nullable: true),
                    MonthRealValue = table.Column<double>(type: "float", nullable: true),
                    MonthPerformancePercent = table.Column<double>(type: "float", nullable: true),
                    MonthRealizationPercent = table.Column<double>(type: "float", nullable: true),
                    FourMonthsOKRTargetValue = table.Column<double>(type: "float", nullable: true),
                    FourMonthsOKRRealValue = table.Column<double>(type: "float", nullable: true),
                    FourMonthsOKRPerformancePercent = table.Column<double>(type: "float", nullable: true),
                    FourMonthsOKRRealizationPercent = table.Column<double>(type: "float", nullable: true),
                    YearlyTargetValue = table.Column<double>(type: "float", nullable: true),
                    YearlyRealValue = table.Column<double>(type: "float", nullable: true),
                    YearlyPerformancePercent = table.Column<double>(type: "float", nullable: true),
                    YearlyRealizationPercent = table.Column<double>(type: "float", nullable: true),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incomes_Clusters_ClusterId",
                        column: x => x.ClusterId,
                        principalTable: "Clusters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incomes_DateRanges_DateRangeId",
                        column: x => x.DateRangeId,
                        principalTable: "DateRanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CellPhoneNumber", "DeletedUserId", "Description", "EmailAddress", "FullName", "InsertDateTime", "IsActive", "IsDeleted", "NationalCode", "Password", "Type", "Username" },
                values: new object[] { new Guid("bfeea5f6-a908-4140-90bd-cf11001ba70c"), "09120717168", null, null, null, "محسن فرخی", new DateTime(2021, 2, 28, 15, 4, 33, 256, DateTimeKind.Local).AddTicks(1661), true, false, null, "5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8", 900, "m.farokhi" });

            migrationBuilder.CreateIndex(
                name: "IX_ClusterCosts_ClusterId",
                table: "ClusterCosts",
                column: "ClusterId");

            migrationBuilder.CreateIndex(
                name: "IX_ClusterCosts_DateRangeId",
                table: "ClusterCosts",
                column: "DateRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_DateRanges_UserId",
                table: "DateRanges",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HeadquarterCosts_DateRangeId",
                table: "HeadquarterCosts",
                column: "DateRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_ClusterId",
                table: "Incomes",
                column: "ClusterId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_DateRangeId",
                table: "Incomes",
                column: "DateRangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_ParentId",
                table: "Operations",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationsOfGroups_OperationId",
                table: "OperationsOfGroups",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsersOfGroups_UserId",
                table: "UsersOfGroups",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClusterCosts");

            migrationBuilder.DropTable(
                name: "HeadquarterCosts");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "OperationsOfGroups");

            migrationBuilder.DropTable(
                name: "UsersOfGroups");

            migrationBuilder.DropTable(
                name: "Clusters");

            migrationBuilder.DropTable(
                name: "DateRanges");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
