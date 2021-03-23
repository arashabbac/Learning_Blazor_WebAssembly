using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class v_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Indicator",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Clusters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("1b282c14-1616-447f-8f8f-f587c85ce97d"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 4, 11, 45, 4, 587, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("69d98efe-e507-4e68-830e-021324eb2da8"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 4, 11, 45, 4, 587, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("7594c261-b33d-4a3d-91c2-5f4198032a6a"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 4, 11, 45, 4, 586, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("f0bd5c41-4dc4-4c94-ab07-697d336bcdbd"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 4, 11, 45, 4, 587, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1c219a-dc0d-4ee4-a8d6-2808e43232a7"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 4, 11, 45, 4, 575, DateTimeKind.Local).AddTicks(3437));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Indicator");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Clusters");

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("1b282c14-1616-447f-8f8f-f587c85ce97d"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 14, 37, 9, 663, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("69d98efe-e507-4e68-830e-021324eb2da8"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 14, 37, 9, 663, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("7594c261-b33d-4a3d-91c2-5f4198032a6a"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 14, 37, 9, 663, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("f0bd5c41-4dc4-4c94-ab07-697d336bcdbd"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 14, 37, 9, 663, DateTimeKind.Local).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1c219a-dc0d-4ee4-a8d6-2808e43232a7"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 14, 37, 9, 656, DateTimeKind.Local).AddTicks(1569));
        }
    }
}
