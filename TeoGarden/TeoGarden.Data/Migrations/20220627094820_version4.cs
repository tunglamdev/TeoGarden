using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeoGarden.Data.Migrations
{
    public partial class version4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9830), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9834), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9837), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9840), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9841) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9843), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9844) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9845), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(309), new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(304) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(314), new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(317), new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(319), new DateTime(2022, 6, 27, 16, 48, 19, 322, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9900), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9902) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9906), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9907) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9909), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9413) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9417), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9420), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9422), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9425), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9428), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9431), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9432) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9434), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9437), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9439), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9442), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9444), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9493), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9496), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9540), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9541) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9546), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9548), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9549) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9551), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9553), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9554) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9556), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9559), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9561), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9564), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9567), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9570), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9573), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9576), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9578), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9581), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9583), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9584) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9586), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9589), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9596), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9598), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9601), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9604), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9606), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9609), new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9609) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedDate", "Role", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3688), 1, new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3294), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3314), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3317), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3320), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3326), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3329), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3331), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3332) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3334), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3336), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3339), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3341), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3344), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3346), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3349), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3352), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3354), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3357), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3359), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3362), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3365), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3367), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3370), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3373), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3375), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3378), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3381), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3384), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3387), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3389), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3395), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3397), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3403), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3405), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3411), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 6, 27, 16, 38, 41, 94, DateTimeKind.Local).AddTicks(3414) });
        }
    }
}
