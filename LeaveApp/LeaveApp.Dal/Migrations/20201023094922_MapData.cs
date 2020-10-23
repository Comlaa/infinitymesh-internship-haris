using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApp.Dal.Migrations
{
    public partial class MapData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateModified" },
                values: new object[] { new DateTime(2020, 10, 23, 9, 49, 21, 205, DateTimeKind.Utc).AddTicks(6807), new DateTime(2020, 10, 23, 11, 49, 21, 205, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateModified", "ModifiedAt", "RoleName" },
                values: new object[] { 2, new DateTime(2020, 10, 23, 9, 49, 21, 209, DateTimeKind.Utc).AddTicks(1730), null, new DateTime(2020, 10, 23, 11, 49, 21, 209, DateTimeKind.Local).AddTicks(1758), null, "Moderator" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 23, 9, 49, 21, 202, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DepartmentID", "Email", "JobTitleID", "ModifiedAt", "Password", "UserName" },
                values: new object[,]
                {
                    { 2, new DateTime(2020, 10, 23, 9, 49, 21, 203, DateTimeKind.Utc).AddTicks(498), null, 1, "amujkic@infinitymesh.com", 2, null, "12345", "amujkic" },
                    { 3, new DateTime(2020, 10, 23, 9, 49, 21, 203, DateTimeKind.Utc).AddTicks(584), null, 1, "nedzada@edu.fit.ba", 1, null, "12345", "nalibegovic" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
