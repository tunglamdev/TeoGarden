using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeoGarden.Data.Migrations
{
    public partial class version3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Sale",
                table: "Vegetables",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Vegetables",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsBlocked",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Feedbacks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3573), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3646), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3649), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3651), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3652) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3654), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3656), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3736), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3734) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3739), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3741), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3743), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3681), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3685), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3688), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3294), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3311), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3314), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3317), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3320), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3323), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3326), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3329), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3331), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3334), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3336), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3339), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3341), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3344), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3346), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3349), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3352), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3354), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3357), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3359), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3362), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3365), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3367), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3370), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3373), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3375), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3378), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3381), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3384), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3387), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3389), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3392), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3395), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3397), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3400), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3403), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3405), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3408), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3411), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3413), false, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3414) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Vegetables");

            migrationBuilder.DropColumn(
                name: "IsBlocked",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "Sale",
                table: "Vegetables",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

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
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8274), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8288), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8289), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8291), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8291) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8312), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8314), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8315), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8316) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8316), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8317) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8318), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8319), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8322), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8323), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8324), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8326), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8327), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8328), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8329) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8330), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8331), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8332), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8335), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8336), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8338), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8339), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8340), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8342), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8343), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8345), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8346), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8348), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8350), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8351), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8352) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8352), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8354), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8356), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8357) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8358), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8358) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8359), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8360), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8362), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8362) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8363), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "Sale", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8365), 0, new DateTime(2022, 6, 27, 15, 39, 0, 513, DateTimeKind.Local).AddTicks(8365) });
        }
    }
}
