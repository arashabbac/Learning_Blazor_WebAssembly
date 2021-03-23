using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class init_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("19f4a5ac-09a9-4f18-ac11-57f3017a4c9e"));

            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("6254bd26-f82e-4bfc-927a-bd6a590a089a"));

            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("8c4d1951-bd64-4b16-9835-7cfa744013b0"));

            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("aa966bbc-8c7f-447a-b20b-4b329fa38908"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d06ab9be-ce41-4626-bb33-d52d62614bca"));

            migrationBuilder.AlterColumn<double>(
                name: "TargetValue",
                table: "HeadquarterCosts",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RealValue",
                table: "HeadquarterCosts",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clusters",
                columns: new[] { "Id", "InsertDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("6402cdab-8eaa-47cd-9509-528df72d8cc8"), new DateTime(2021, 3, 2, 9, 24, 30, 132, DateTimeKind.Local).AddTicks(998), "مدیریت توسعه پایدار" },
                    { new Guid("35ef59c5-167e-4c90-ae85-a8c5ca5cc0fd"), new DateTime(2021, 3, 2, 9, 24, 30, 132, DateTimeKind.Local).AddTicks(2327), "مدیریت زیبوم" },
                    { new Guid("935d846a-d90d-4206-b9d5-f21d51641775"), new DateTime(2021, 3, 2, 9, 24, 30, 132, DateTimeKind.Local).AddTicks(2346), "مدیریت تجارت الکترونیک" },
                    { new Guid("2c977c4f-cc62-4822-97c9-e11f986ec99f"), new DateTime(2021, 3, 2, 9, 24, 30, 132, DateTimeKind.Local).AddTicks(2361), "مدیریت پست و لجستیک" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CellPhoneNumber", "DeletedUserId", "Description", "EmailAddress", "FullName", "InsertDateTime", "IsActive", "IsDeleted", "NationalCode", "Password", "Type", "Username" },
                values: new object[] { new Guid("f22ba130-f727-4522-9a4b-6652cb3231f8"), "09120717168", null, null, null, "محسن فرخی", new DateTime(2021, 3, 2, 9, 24, 30, 125, DateTimeKind.Local).AddTicks(2142), true, false, null, "5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8", 900, "m.farokhi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("2c977c4f-cc62-4822-97c9-e11f986ec99f"));

            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("35ef59c5-167e-4c90-ae85-a8c5ca5cc0fd"));

            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("6402cdab-8eaa-47cd-9509-528df72d8cc8"));

            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("935d846a-d90d-4206-b9d5-f21d51641775"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f22ba130-f727-4522-9a4b-6652cb3231f8"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TargetValue",
                table: "HeadquarterCosts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RealValue",
                table: "HeadquarterCosts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clusters",
                columns: new[] { "Id", "InsertDateTime", "Name" },
                values: new object[,]
                {
                    { new Guid("6254bd26-f82e-4bfc-927a-bd6a590a089a"), new DateTime(2021, 3, 1, 15, 38, 15, 722, DateTimeKind.Local).AddTicks(4194), "مدیریت توسعه پایدار" },
                    { new Guid("8c4d1951-bd64-4b16-9835-7cfa744013b0"), new DateTime(2021, 3, 1, 15, 38, 15, 722, DateTimeKind.Local).AddTicks(5566), "مدیریت زیبوم" },
                    { new Guid("aa966bbc-8c7f-447a-b20b-4b329fa38908"), new DateTime(2021, 3, 1, 15, 38, 15, 722, DateTimeKind.Local).AddTicks(5585), "مدیریت تجارت الکترونیک" },
                    { new Guid("19f4a5ac-09a9-4f18-ac11-57f3017a4c9e"), new DateTime(2021, 3, 1, 15, 38, 15, 722, DateTimeKind.Local).AddTicks(5650), "مدیریت پست و لجستیک" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CellPhoneNumber", "DeletedUserId", "Description", "EmailAddress", "FullName", "InsertDateTime", "IsActive", "IsDeleted", "NationalCode", "Password", "Type", "Username" },
                values: new object[] { new Guid("d06ab9be-ce41-4626-bb33-d52d62614bca"), "09120717168", null, null, null, "محسن فرخی", new DateTime(2021, 3, 1, 15, 38, 15, 713, DateTimeKind.Local).AddTicks(2396), true, false, null, "5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8", 900, "m.farokhi" });
        }
    }
}
