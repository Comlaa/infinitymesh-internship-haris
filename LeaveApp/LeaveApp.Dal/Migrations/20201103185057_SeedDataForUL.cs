using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApp.Dal.Migrations
{
    public partial class SeedDataForUL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SpecialLeave",
                table: "Leaves",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalDays",
                table: "Leaves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 3, 18, 50, 56, 840, DateTimeKind.Utc).AddTicks(9596), new DateTime(2020, 11, 3, 19, 50, 56, 841, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2020, 11, 3, 18, 50, 56, 846, DateTimeKind.Utc).AddTicks(7081), new DateTime(2020, 11, 3, 19, 50, 56, 846, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.InsertData(
                table: "UserLeaves",
                columns: new[] { "UserId", "LeaveId", "ApprovedBy", "EndingDate", "IsAproved", "StartingDate", "UserReplacment" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 1, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 3, 18, 50, 56, 851, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 11, 3, 18, 50, 56, 852, DateTimeKind.Utc).AddTicks(958));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserLeaves",
                keyColumns: new[] { "UserId", "LeaveId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "UserLeaves",
                keyColumns: new[] { "UserId", "LeaveId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserLeaves",
                keyColumns: new[] { "UserId", "LeaveId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DropColumn(
                name: "SpecialLeave",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "TotalDays",
                table: "Leaves");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 26, 9, 51, 51, 150, DateTimeKind.Utc).AddTicks(814), new DateTime(2020, 10, 26, 10, 51, 51, 150, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 26, 9, 51, 51, 154, DateTimeKind.Utc).AddTicks(5178), new DateTime(2020, 10, 26, 10, 51, 51, 154, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 9, 51, 51, 158, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 26, 9, 51, 51, 158, DateTimeKind.Utc).AddTicks(5159));
        }
    }
}
