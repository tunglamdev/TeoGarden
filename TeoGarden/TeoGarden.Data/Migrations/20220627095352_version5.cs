using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeoGarden.Data.Migrations
{
    public partial class version5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1755), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1759), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1760) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1762), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1765), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1768), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1771), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4,
                column: "FeedbackTime",
                value: new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2104), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2108), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2111), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DeliveryTime", "OrderTime" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2115), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1823), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1992), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "IsAdmin", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1997), true, "John", new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1111), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1133), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1135) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1138), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1139) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1142), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1145), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1148), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1151), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1154), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1157), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1159) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1161), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1164), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1167), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1169) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1171), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1173) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1175), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1176) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1178), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1179) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1181), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1184), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1187), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1190), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1193), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1196), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1201), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1204), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1207), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1211), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1214), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1218), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1219) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1221), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1222) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1224), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1225) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1227), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1231), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1235), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1238), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1241), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1244), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1248), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1251), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1254), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1258), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1261), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1262) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "IsAdmin", "Name", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9909), false, "Jonson Admin", new DateTime(2022, 6, 27, 16, 48, 19, 321, DateTimeKind.Local).AddTicks(9910) });

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
    }
}
