using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeoGarden.Data.Migrations
{
    public partial class version6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sale",
                table: "Vegetables",
                newName: "IsSale");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSale",
                table: "Vegetables",
                newName: "Sale");

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1997), new DateTime(2022, 6, 27, 16, 53, 51, 973, DateTimeKind.Local).AddTicks(1998) });

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
    }
}
