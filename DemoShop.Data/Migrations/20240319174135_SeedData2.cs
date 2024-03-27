using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoShop.Data.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 0, 41, 35, 313, DateTimeKind.Local).AddTicks(8922),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 3, 20, 0, 39, 1, 319, DateTimeKind.Local).AddTicks(1299));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 3, 20, 0, 39, 1, 319, DateTimeKind.Local).AddTicks(1299),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 3, 20, 0, 41, 35, 313, DateTimeKind.Local).AddTicks(8922));
        }
    }
}
