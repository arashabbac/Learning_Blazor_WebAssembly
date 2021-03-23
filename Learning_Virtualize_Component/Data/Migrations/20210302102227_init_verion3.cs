using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class init_verion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<double>(
                name: "TargetValue",
                table: "ClusterCosts",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "RealValue",
                table: "ClusterCosts",
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
                    { new Guid("7594c261-b33d-4a3d-91c2-5f4198032a6a"), new DateTime(2021, 3, 2, 13, 52, 27, 220, DateTimeKind.Local).AddTicks(1835), "مدیریت توسعه پایدار" },
                    { new Guid("f0bd5c41-4dc4-4c94-ab07-697d336bcdbd"), new DateTime(2021, 3, 2, 13, 52, 27, 220, DateTimeKind.Local).AddTicks(3139), "مدیریت زیبوم" },
                    { new Guid("69d98efe-e507-4e68-830e-021324eb2da8"), new DateTime(2021, 3, 2, 13, 52, 27, 220, DateTimeKind.Local).AddTicks(3161), "مدیریت تجارت الکترونیک" },
                    { new Guid("1b282c14-1616-447f-8f8f-f587c85ce97d"), new DateTime(2021, 3, 2, 13, 52, 27, 220, DateTimeKind.Local).AddTicks(3170), "مدیریت پست و لجستیک" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CellPhoneNumber", "DeletedUserId", "Description", "EmailAddress", "FullName", "InsertDateTime", "IsActive", "IsDeleted", "NationalCode", "Password", "Type", "Username" },
                values: new object[] { new Guid("5f1c219a-dc0d-4ee4-a8d6-2808e43232a7"), "09120717168", null, null, null, "محسن فرخی", new DateTime(2021, 3, 2, 13, 52, 27, 213, DateTimeKind.Local).AddTicks(2479), true, false, null, "5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8", 900, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("1b282c14-1616-447f-8f8f-f587c85ce97d"));

            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("69d98efe-e507-4e68-830e-021324eb2da8"));

            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("7594c261-b33d-4a3d-91c2-5f4198032a6a"));

            migrationBuilder.DeleteData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("f0bd5c41-4dc4-4c94-ab07-697d336bcdbd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1c219a-dc0d-4ee4-a8d6-2808e43232a7"));

            migrationBuilder.AlterColumn<decimal>(
                name: "TargetValue",
                table: "ClusterCosts",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RealValue",
                table: "ClusterCosts",
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
    }
}
