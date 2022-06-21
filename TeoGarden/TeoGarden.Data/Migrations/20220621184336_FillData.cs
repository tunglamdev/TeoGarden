using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeoGarden.Data.Migrations
{
    public partial class FillData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "1.jpg", "Rau" },
                    { 2, "2.jpg", "Củ" },
                    { 3, "3.jpg", "Quả" },
                    { 4, "4.jpg", "Nấm" },
                    { 5, "5.jpg", "Bông" },
                    { 6, "6.jpg", "Hạt" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Chưa xử lý" },
                    { 2, "Đang chuẩn bị" },
                    { 3, "Đang giao hàng" },
                    { 4, "Đã giao hàng" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Avatar", "Email", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Cộng Hòa, Q.Tân Bình, TP.HCM", "lam.jpg", "lam@gmail.com", "Nguyễn Tùng Lâm", "12345", "0338307449" },
                    { 2, "Phan Đăng Lưu, Q.Phú Nhuận, TP.HCM", "an.jpg", "an@gmail.com", "Nguyễn Văn An", "12345", "0338307449" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Avatar", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { 3, "Califonia, Hoa Kỳ", "admin.jpg", "admin@gmail.com", "Jonson Admin", "12345", "0338307449", 1 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DeliveryTime", "OrderTime", "StatusId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(144), 1, 1 },
                    { 2, new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(161), new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(161), 2, 1 },
                    { 3, new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(163), new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(162), 3, 1 },
                    { 4, new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(164), 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Vegetables",
                columns: new[] { "Id", "CategoryId", "Image", "Location", "Name", "Price", "Weight" },
                values: new object[,]
                {
                    { 1, 1, "1.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bạc hà", 10000, 500 },
                    { 2, 1, "2.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bắp cải tím", 15000, 500 },
                    { 3, 1, "3.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bắp cải trắng", 15000, 500 },
                    { 4, 1, "4.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bắp chuối bào", 10000, 500 },
                    { 5, 3, "5.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bắp non", 25000, 500 },
                    { 6, 3, "6.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bầu", 10000, 500 },
                    { 7, 3, "8.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bí đao", 8000, 500 },
                    { 8, 3, "8.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bí đỏ", 10000, 500 },
                    { 9, 3, "9.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bí ngòi", 10000, 500 },
                    { 10, 5, "10.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bông bí", 10000, 500 },
                    { 11, 5, "11.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bông hẹ", 10000, 500 },
                    { 12, 5, "12.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bông so đũa", 10000, 500 },
                    { 13, 5, "13.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bông thiên lý", 10000, 500 },
                    { 14, 3, "14.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cà chua", 10000, 500 },
                    { 15, 3, "15.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cà pháo", 10000, 500 },
                    { 16, 2, "6.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cà rốt", 10000, 500 },
                    { 17, 3, "17.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cà tím", 10000, 500 },
                    { 18, 1, "18.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải bẹ dưa", 5000, 500 },
                    { 19, 1, "19.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải bẹ dún", 5000, 500 },
                    { 20, 1, "20.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải bẹ xanh", 5000, 500 },
                    { 21, 1, "21.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải bó xôi", 15000, 500 },
                    { 22, 1, "22.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải ngọt", 5000, 500 },
                    { 23, 1, "23.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải thảo", 10000, 500 },
                    { 24, 1, "24.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải xà lách", 10000, 500 },
                    { 25, 1, "25.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Xà lách tím", 10000, 500 },
                    { 26, 1, "26.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Xà lách xoang", 10000, 500 },
                    { 27, 1, "27.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Xà lách lụa", 10000, 500 },
                    { 28, 1, "28.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cần dày lá", 10000, 500 },
                    { 29, 1, "29.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cần tây", 10000, 500 },
                    { 30, 1, "30.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cần ô", 10000, 500 },
                    { 31, 3, "31.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Chanh", 20000, 500 },
                    { 32, 2, "32.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Củ cải trắng", 10000, 500 },
                    { 33, 2, "33.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Củ dền", 10000, 500 },
                    { 34, 3, "34.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu bắp", 10000, 500 },
                    { 35, 1, "35.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu đũa", 10000, 500 },
                    { 36, 1, "36.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu Hà Lan", 10000, 500 },
                    { 37, 1, "37.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu que", 10000, 500 },
                    { 38, 1, "38.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu rồng", 10000, 500 }
                });

            migrationBuilder.InsertData(
                table: "Vegetables",
                columns: new[] { "Id", "CategoryId", "Image", "Location", "Name", "Price", "Weight" },
                values: new object[] { 39, 1, "39.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu ván", 10000, 500 });

            migrationBuilder.InsertData(
                table: "Vegetables",
                columns: new[] { "Id", "CategoryId", "Image", "Location", "Name", "Price", "Weight" },
                values: new object[] { 40, 3, "40.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Dưa gan", 10000, 500 });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "UserId", "VegetableId", "Amount" },
                values: new object[,]
                {
                    { 1, 18, 2 },
                    { 1, 24, 3 },
                    { 1, 31, 1 },
                    { 2, 40, 2 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Comment", "FeedbackTime", "UserId", "VegetableId", "Vote" },
                values: new object[,]
                {
                    { 1, "Rau tươi ngon", new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(227), 1, 18, 5 },
                    { 2, "Rau héo", new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(229), 1, 31, 3 },
                    { 3, "Rau tươi quá", new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(230), 2, 24, 4 },
                    { 4, "Rau không tươi", new DateTime(2022, 6, 22, 1, 43, 36, 108, DateTimeKind.Local).AddTicks(231), 2, 40, 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "VegetableId", "Amount", "OrderPrice" },
                values: new object[,]
                {
                    { 1, 1, 2, 5000 },
                    { 2, 8, 3, 10000 },
                    { 1, 10, 1, 15000 },
                    { 1, 26, 2, 10000 },
                    { 4, 28, 2, 5000 },
                    { 3, 33, 2, 15000 },
                    { 2, 40, 2, 15000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumns: new[] { "UserId", "VegetableId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumns: new[] { "UserId", "VegetableId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumns: new[] { "UserId", "VegetableId" },
                keyValues: new object[] { 1, 31 });

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumns: new[] { "UserId", "VegetableId" },
                keyValues: new object[] { 2, 40 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feedbacks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "VegetableId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "VegetableId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "VegetableId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "VegetableId" },
                keyValues: new object[] { 1, 26 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "VegetableId" },
                keyValues: new object[] { 4, 28 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "VegetableId" },
                keyValues: new object[] { 3, 33 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "VegetableId" },
                keyValues: new object[] { 2, 40 });

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Vegetables",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
