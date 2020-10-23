using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApp.Dal.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DateModified", "ModifiedAt", "RoleName" },
                values: new object[] { 1, new DateTime(2020, 10, 23, 5, 2, 31, 785, DateTimeKind.Utc).AddTicks(1602), null, new DateTime(2020, 10, 23, 7, 2, 31, 785, DateTimeKind.Local).AddTicks(3932), null, "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DepartmentID", "Email", "JobTitleID", "ModifiedAt", "Password", "UserName" },
                values: new object[] { 1, new DateTime(2020, 10, 23, 5, 2, 31, 780, DateTimeKind.Utc).AddTicks(1179), null, 1, "haris.mlaco@edu.fit.ba", 1, null, "12345", "comlaa" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
