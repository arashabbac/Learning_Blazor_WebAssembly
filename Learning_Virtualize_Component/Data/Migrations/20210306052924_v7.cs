using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ordering",
                table: "Clusters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("1b282c14-1616-447f-8f8f-f587c85ce97d"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 6, 8, 59, 24, 46, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("69d98efe-e507-4e68-830e-021324eb2da8"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 6, 8, 59, 24, 46, DateTimeKind.Local).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("7594c261-b33d-4a3d-91c2-5f4198032a6a"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 6, 8, 59, 24, 46, DateTimeKind.Local).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("f0bd5c41-4dc4-4c94-ab07-697d336bcdbd"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 6, 8, 59, 24, 46, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1c219a-dc0d-4ee4-a8d6-2808e43232a7"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 6, 8, 59, 24, 39, DateTimeKind.Local).AddTicks(7395));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ordering",
                table: "Clusters");

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("1b282c14-1616-447f-8f8f-f587c85ce97d"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 5, 18, 1, 48, 840, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("69d98efe-e507-4e68-830e-021324eb2da8"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 5, 18, 1, 48, 840, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("7594c261-b33d-4a3d-91c2-5f4198032a6a"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 5, 18, 1, 48, 839, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("f0bd5c41-4dc4-4c94-ab07-697d336bcdbd"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 5, 18, 1, 48, 840, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1c219a-dc0d-4ee4-a8d6-2808e43232a7"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 5, 18, 1, 48, 814, DateTimeKind.Local).AddTicks(3327));
        }
    }
}
