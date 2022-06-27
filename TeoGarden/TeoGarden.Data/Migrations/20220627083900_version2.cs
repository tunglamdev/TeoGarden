using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeoGarden.Data.Migrations
{
    public partial class version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8471), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8473), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8474), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8475), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8475) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8476), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8518), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8517) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8519), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8519) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8522), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8492), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8493), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8274), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8288), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8289), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8291), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8312), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8314), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8315), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8316), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8318), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8319), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8322), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8323), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8324), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8326), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8327), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8328), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8331), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8332), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8335), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8336), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8338), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8339), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8342), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8343), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8345), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8346), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8348), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8351), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8352), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8354), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8356), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8358), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8359), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8360), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8362), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8363), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8365), new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8365) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Vegetables");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Vegetables");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(161), new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(163), new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(164) });
        }
    }
}
