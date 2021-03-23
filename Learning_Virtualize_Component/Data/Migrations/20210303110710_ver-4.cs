using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class ver4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClusterIndicatorType",
                table: "ClusterCosts");

            migrationBuilder.AddColumn<Guid>(
                name: "IndicatorId",
                table: "ClusterCosts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_ClusterCosts_IndicatorId",
                table: "ClusterCosts",
                column: "IndicatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClusterCosts_Indicator_IndicatorId",
                table: "ClusterCosts",
                column: "IndicatorId",
                principalTable: "Indicator",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClusterCosts_Indicator_IndicatorId",
                table: "ClusterCosts");

            migrationBuilder.DropIndex(
                name: "IX_ClusterCosts_IndicatorId",
                table: "ClusterCosts");

            migrationBuilder.DropColumn(
                name: "IndicatorId",
                table: "ClusterCosts");

            migrationBuilder.AddColumn<byte>(
                name: "ClusterIndicatorType",
                table: "ClusterCosts",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("1b282c14-1616-447f-8f8f-f587c85ce97d"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 13, 48, 6, 442, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("69d98efe-e507-4e68-830e-021324eb2da8"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 13, 48, 6, 442, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("7594c261-b33d-4a3d-91c2-5f4198032a6a"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 13, 48, 6, 441, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("f0bd5c41-4dc4-4c94-ab07-697d336bcdbd"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 13, 48, 6, 442, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1c219a-dc0d-4ee4-a8d6-2808e43232a7"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 3, 13, 48, 6, 434, DateTimeKind.Local).AddTicks(5771));
        }
    }
}
