using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApp.Dal.Migrations
{
    public partial class AddDataFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 23, 5, 44, 45, 893, DateTimeKind.Utc).AddTicks(2612), new DateTime(2020, 10, 23, 7, 44, 45, 893, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 23, 5, 44, 45, 889, DateTimeKind.Utc).AddTicks(7133));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 23, 5, 2, 31, 785, DateTimeKind.Utc).AddTicks(1602), new DateTime(2020, 10, 23, 7, 2, 31, 785, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 23, 5, 2, 31, 780, DateTimeKind.Utc).AddTicks(1179));
        }
    }
}
