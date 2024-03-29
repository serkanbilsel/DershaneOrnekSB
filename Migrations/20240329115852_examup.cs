using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DershaneOrnekSB.Migrations
{
    /// <inheritdoc />
    public partial class examup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsTopMenu = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    OrderNo = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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
                name: "IX_Exams_CategoryId",
                table: "Exams",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Categories_CategoryId",
                table: "Exams",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Categories_CategoryId",
                table: "Exams");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Exams_CategoryId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Exams");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5795));
        }
    }
}
