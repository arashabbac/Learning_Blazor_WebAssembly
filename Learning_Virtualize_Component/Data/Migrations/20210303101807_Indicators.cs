using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Indicators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Indicator",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InsertDateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndicatorsOfClusters",
                columns: table => new
                {
                    ClusterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndicatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndicatorsOfClusters", x => new { x.ClusterId, x.IndicatorId });
                    table.ForeignKey(
                        name: "FK_IndicatorsOfClusters_Clusters_ClusterId",
                        column: x => x.ClusterId,
                        principalTable: "Clusters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndicatorsOfClusters_Indicator_IndicatorId",
                        column: x => x.IndicatorId,
                        principalTable: "Indicator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_IndicatorsOfClusters_IndicatorId",
                table: "IndicatorsOfClusters",
                column: "IndicatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndicatorsOfClusters");

            migrationBuilder.DropTable(
                name: "Indicator");

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("1b282c14-1616-447f-8f8f-f587c85ce97d"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 2, 13, 52, 27, 220, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("69d98efe-e507-4e68-830e-021324eb2da8"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 2, 13, 52, 27, 220, DateTimeKind.Local).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("7594c261-b33d-4a3d-91c2-5f4198032a6a"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 2, 13, 52, 27, 220, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Clusters",
                keyColumn: "Id",
                keyValue: new Guid("f0bd5c41-4dc4-4c94-ab07-697d336bcdbd"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 2, 13, 52, 27, 220, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5f1c219a-dc0d-4ee4-a8d6-2808e43232a7"),
                column: "InsertDateTime",
                value: new DateTime(2021, 3, 2, 13, 52, 27, 213, DateTimeKind.Local).AddTicks(2479));
        }
    }
}
