using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveApp.Dal.Migrations
{
    public partial class NewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leaves",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true, comment: "This is the default comment."),
                    LeaveType = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLeaves",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LeaveId = table.Column<int>(nullable: false),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    EndingDate = table.Column<DateTime>(nullable: false),
                    ApprovedBy = table.Column<string>(nullable: true),
                    IsAproved = table.Column<bool>(nullable: false),
                    UserReplacmentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLeaves", x => new { x.UserId, x.LeaveId });
                    table.ForeignKey(
                        name: "FK_UserLeaves_Leaves_LeaveId",
                        column: x => x.LeaveId,
                        principalTable: "Leaves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLeaves_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLeaves_Users_UserReplacmentId",
                        column: x => x.UserReplacmentId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true, comment: "This is the default comment."),
                    UserId = table.Column<int>(nullable: false),
                    LeaveId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    EmailTo = table.Column<string>(nullable: true),
                    EmailFrom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_UserLeaves_UserId_LeaveId",
                        columns: x => new { x.UserId, x.LeaveId },
                        principalTable: "UserLeaves",
                        principalColumns: new[] { "UserId", "LeaveId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId_LeaveId",
                table: "Notifications",
                columns: new[] { "UserId", "LeaveId" });

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaves_LeaveId",
                table: "UserLeaves",
                column: "LeaveId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLeaves_UserReplacmentId",
                table: "UserLeaves",
                column: "UserReplacmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "UserLeaves");

            migrationBuilder.DropTable(
                name: "Leaves");
        }
    }
}
