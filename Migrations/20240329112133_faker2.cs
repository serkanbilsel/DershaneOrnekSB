using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DershaneOrnekSB.Migrations
{
    /// <inheritdoc />
    public partial class faker2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Email", "Name" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5772), "user1@test.com", "User1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "Email", "IsActive", "IsAdmin", "Name", "Password", "Phone", "Surname", "UserGuid" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5771), "hakki@test.com", true, false, "Hakki", "123", null, null, null },
                    { 4, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5773), "user2@test.com", true, false, "User2", "123", null, null, null },
                    { 5, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5774), "user3@test.com", true, false, "User3", "123", null, null, null },
                    { 6, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5775), "user4@test.com", true, false, "User4", "123", null, null, null },
                    { 7, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5776), "user5@test.com", true, false, "User5", "123", null, null, null },
                    { 8, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5777), "user6@test.com", true, false, "User6", "123", null, null, null },
                    { 9, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5778), "user7@test.com", true, false, "User7", "123", null, null, null },
                    { 10, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5779), "user8@test.com", true, false, "User8", "123", null, null, null },
                    { 11, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5780), "user9@test.com", true, false, "User9", "123", null, null, null },
                    { 12, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5781), "user10@test.com", true, false, "User10", "123", null, null, null },
                    { 13, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5782), "user11@test.com", true, false, "User11", "123", null, null, null },
                    { 14, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5783), "user12@test.com", true, false, "User12", "123", null, null, null },
                    { 15, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5784), "user13@test.com", true, false, "User13", "123", null, null, null },
                    { 16, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5785), "user14@test.com", true, false, "User14", "123", null, null, null },
                    { 17, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5786), "user15@test.com", true, false, "User15", "123", null, null, null },
                    { 18, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5787), "user16@test.com", true, false, "User16", "123", null, null, null },
                    { 19, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5788), "user17@test.com", true, false, "User17", "123", null, null, null },
                    { 20, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5789), "user18@test.com", true, false, "User18", "123", null, null, null },
                    { 21, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5789), "user19@test.com", true, false, "User19", "123", null, null, null },
                    { 22, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5790), "user20@test.com", true, false, "User20", "123", null, null, null },
                    { 23, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5791), "user21@test.com", true, false, "User21", "123", null, null, null },
                    { 24, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5792), "user22@test.com", true, false, "User22", "123", null, null, null },
                    { 25, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5793), "user23@test.com", true, false, "User23", "123", null, null, null },
                    { 26, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5794), "user24@test.com", true, false, "User24", "123", null, null, null },
                    { 27, new DateTime(2024, 3, 29, 14, 21, 33, 714, DateTimeKind.Local).AddTicks(5795), "user25@test.com", true, false, "User25", "123", null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 3, 29, 14, 17, 29, 398, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDate", "Email", "Name" },
                values: new object[] { new DateTime(2024, 3, 29, 14, 17, 29, 398, DateTimeKind.Local).AddTicks(8055), "hakki@test.com", "Hakki" });
        }
    }
}
