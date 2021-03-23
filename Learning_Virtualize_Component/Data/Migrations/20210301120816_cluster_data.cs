using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class cluster_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bfeea5f6-a908-4140-90bd-cf11001ba70c"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CellPhoneNumber", "DeletedUserId", "Description", "EmailAddress", "FullName", "InsertDateTime", "IsActive", "IsDeleted", "NationalCode", "Password", "Type", "Username" },
                values: new object[] { new Guid("bfeea5f6-a908-4140-90bd-cf11001ba70c"), "09120717168", null, null, null, "محسن فرخی", new DateTime(2021, 2, 28, 15, 4, 33, 256, DateTimeKind.Local).AddTicks(1661), true, false, null, "5BAA61E4C9B93F3F0682250B6CF8331B7EE68FD8", 900, "m.farokhi" });
        }
    }
}
