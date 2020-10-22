using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApp.Dal.Migrations
{
    public partial class UserUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLeaves_Users_UserReplacmentId",
                table: "UserLeaves");

            migrationBuilder.DropIndex(
                name: "IX_UserLeaves_UserReplacmentId",
                table: "UserLeaves");

            migrationBuilder.DropColumn(
                name: "UserReplacmentId",
                table: "UserLeaves");

            migrationBuilder.AddColumn<string>(
                name: "UserReplacment",
                table: "UserLeaves",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserReplacment",
                table: "UserLeaves");

            migrationBuilder.AddColumn<int>(
                name: "UserReplacmentId",
                table: "UserLeaves",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaves_UserReplacmentId",
                table: "UserLeaves",
                column: "UserReplacmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLeaves_Users_UserReplacmentId",
                table: "UserLeaves",
                column: "UserReplacmentId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
