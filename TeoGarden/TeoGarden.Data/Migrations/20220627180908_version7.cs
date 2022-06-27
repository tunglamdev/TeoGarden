using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeoGarden.Data.Migrations
{
    public partial class version7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6291),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(5759),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisteredDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.AlterColumn<DateTime>(
                name: "FeedbackTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7195),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: null);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegisteredDate",
                table: "Users");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Vegetables",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FeedbackTime",
                table: "Feedbacks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 6, 28, 1, 9, 7, 825, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9253), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9257), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9260), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9263), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9308), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9311), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9414), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9418), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9421), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9423), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9345), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9346) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9350), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9353), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9354) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8919), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8938), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8941), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8943), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8947), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8948) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8949), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8952), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8953) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8954), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8955) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8957), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8959), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8962), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8964), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8965) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8967), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8967) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8969), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8973), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8975), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8978), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8983), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8985), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8988), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8993), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8995), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(8999), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9001), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9004), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9006), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9009), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9011), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9053), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9056), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9058), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9061), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9063), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9064) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9066), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9068), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9073), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9073) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9075), new DateTime(2022, 6, 27, 17, 7, 44, 294, DateTimeKind.Local).AddTicks(9076) });
        }
    }
}
