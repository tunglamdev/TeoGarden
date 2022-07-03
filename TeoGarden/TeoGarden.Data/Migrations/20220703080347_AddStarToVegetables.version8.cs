using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeoGarden.Data.Migrations
{
    public partial class AddStarToVegetablesversion8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(9301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(9157),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.AddColumn<double>(
                name: "Stars",
                table: "Vegetables",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(8592),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(8474),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FeedbackTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(9980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(9877),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(939), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(939) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(941), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(942), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(943), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(981), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(982), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackTime",
                value: new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeedbackTime",
                value: new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeedbackTime",
                value: new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeedbackTime",
                value: new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1023), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1024), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1024) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1026), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1027), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(733), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(739), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(741), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(742), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(743), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(745), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(746), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(748), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(749), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(749) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(751), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(753), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(755), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(756), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(758), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(762), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(764), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(766), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(767), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(769), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(770), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(771), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(773), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(774), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(775), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(777), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(779), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(781), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(782), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(783) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(784), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(785), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(786), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(788), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(789), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(792), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(795), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(795) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(796), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(796) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(797), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(798) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(799), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(800), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(802), new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(802) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stars",
                table: "Vegetables");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(5759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegisteredDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(5651),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FeedbackTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 189, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 7, 3, 15, 3, 47, 188, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7641), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7642), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7643), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7645), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7682), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7684), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7685), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7686), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7481), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7483), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7484), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7486), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7487), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7488), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7490), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7491), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7492), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7493), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7495), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7496), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7497), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7499), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7500), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7501), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7502), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7504), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7505), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7531), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7532) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7533), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7534), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7535), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7536) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7537), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7538), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7539), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7541), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7542), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7543), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7544), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7546), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7547), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7548), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7550), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7551), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7552), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7553) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7554), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7554) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7555), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7556), new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7556) });
        }
    }
}
