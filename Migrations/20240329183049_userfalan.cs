using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DershaneOrnekSB.Migrations
{
    /// <inheritdoc />
    public partial class userfalan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Choices_Questions_QuestionId",
                table: "Choices");

            migrationBuilder.DropIndex(
                name: "IX_Choices_QuestionId",
                table: "Choices");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Choices");

            migrationBuilder.AddColumn<string>(
                name: "CorrectAnswer",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Explanation",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsMultipleChoice",
                table: "Questions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 21, 30, 49, 251, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.CreateIndex(
                name: "IX_UserExamAssignments_ExamId",
                table: "UserExamAssignments",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExamAssignments_UserId",
                table: "UserExamAssignments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserExamAssignments_Exams_ExamId",
                table: "UserExamAssignments",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserExamAssignments_Users_UserId",
                table: "UserExamAssignments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserExamAssignments_Exams_ExamId",
                table: "UserExamAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserExamAssignments_Users_UserId",
                table: "UserExamAssignments");

            migrationBuilder.DropIndex(
                name: "IX_UserExamAssignments_ExamId",
                table: "UserExamAssignments");

            migrationBuilder.DropIndex(
                name: "IX_UserExamAssignments_UserId",
                table: "UserExamAssignments");

            migrationBuilder.DropColumn(
                name: "CorrectAnswer",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsMultipleChoice",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Choices",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 58, 52, 447, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.CreateIndex(
                name: "IX_Choices_QuestionId",
                table: "Choices",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Choices_Questions_QuestionId",
                table: "Choices",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id");
        }
    }
}
