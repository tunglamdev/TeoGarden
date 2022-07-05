using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeoGarden.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 7, 5, 18, 30, 23, 449, DateTimeKind.Local).AddTicks(9760)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 7, 5, 18, 30, 23, 449, DateTimeKind.Local).AddTicks(9855)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "default.png"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisteredDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 7, 5, 18, 30, 23, 449, DateTimeKind.Local).AddTicks(8257)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 7, 5, 18, 30, 23, 449, DateTimeKind.Local).AddTicks(8401)),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vegetables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSale = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 7, 5, 18, 30, 23, 449, DateTimeKind.Local).AddTicks(9145)),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 7, 5, 18, 30, 23, 449, DateTimeKind.Local).AddTicks(9263)),
                    Stars = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vegetables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vegetables_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VegetableId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.VegetableId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Carts_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Vegetables_VegetableId",
                        column: x => x.VegetableId,
                        principalTable: "Vegetables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VegetableId = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vote = table.Column<int>(type: "int", nullable: false),
                    FeedbackTime = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValue: new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(218)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Vegetables_VegetableId",
                        column: x => x.VegetableId,
                        principalTable: "Vegetables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    VegetableId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    OrderPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.VegetableId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Vegetables_VegetableId",
                        column: x => x.VegetableId,
                        principalTable: "Vegetables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"), new Guid("372ea575-2536-4076-9bab-3e3138de495f") },
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15") },
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4") }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Image", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1995), "1.jpg", "Rau", new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1995) },
                    { 2, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1996), "2.jpg", "Củ", new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1997) },
                    { 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1997), "3.jpg", "Quả", new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1998) },
                    { 4, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1998), "4.jpg", "Nấm", new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1999) },
                    { 5, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1999), "5.jpg", "Bông", new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(2000) },
                    { 6, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(2001), "6.jpg", "Hạt", new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(2001) }
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
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("372ea575-2536-4076-9bab-3e3138de495f"), 0, "Califonia, Hoa Kỳ", "admin.jpg", "df1a72ac-4712-43b9-9131-04b3bae11c04", "admin@gmail.com", false, false, null, "John", null, null, "AQAAAAEAACcQAAAAEEmem5soddUz91CScRlN/Q/JQ0+Sk2eb+bEtrnmqkQZsAVDUCEAj3XWZjtSNGuJc/g==", null, "0338307449", null, false, null, false, null },
                    { new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"), 0, "Phan Đăng Lưu, Q.Phú Nhuận, TP.HCM", "an.jpg", "6411482c-1cb6-4968-b353-b033eb4641e6", "an@gmail.com", false, false, null, "Nguyễn Văn An", null, null, "AQAAAAEAACcQAAAAEK2/HyIhBCHpfQDpw75fijRSQNRQt4gt7OuYZIGnBi22zQstLNSRk+zOLN3saa2FaQ==", null, "0338307449", null, false, null, false, null },
                    { new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"), 0, "Cộng Hòa, Q.Tân Bình, TP.HCM", "lam.jpg", "6cfd6c99-d6bf-48de-b0c2-8899f065a7a6", "lam@gmail.com", false, false, null, "Nguyễn Tùng Lâm", null, null, "AQAAAAEAACcQAAAAEHv6QY3RJ6yplVbF3fm4p1H5aARz/+mF19SxkdURBH0lGe1NRtyL4DxOgbt8DtpiNg==", null, "0338307449", null, false, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("8f7579ee-4af9-4b71-9ada-7f792f76dc31"), "f1595b50-cf9c-4c24-b52d-e7638bca125e", "Customer role", "customer", "customer" },
                    { new Guid("9e87b492-5343-4272-9a34-fa5de7cffb22"), "9b254e80-48e7-4476-965b-fd897a6c5915", "Administrator role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DeliveryTime", "OrderTime", "StatusId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3636), new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3635), 1, new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4") },
                    { 2, new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3638), new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3638), 2, new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4") },
                    { 3, new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3640), 3, new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15") },
                    { 4, new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3641), new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3641), 1, new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15") }
                });

            migrationBuilder.InsertData(
                table: "Vegetables",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Image", "Location", "Name", "Price", "UpdatedDate", "Weight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1842), "1.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bạc hà", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1844), 500 },
                    { 2, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1846), "2.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bắp cải tím", 15000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1846), 500 },
                    { 3, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1848), "3.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bắp cải trắng", 15000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1848), 500 },
                    { 4, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1849), "4.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bắp chuối bào", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1849), 500 },
                    { 5, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1850), "5.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bắp non", 25000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1851), 500 },
                    { 6, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1852), "6.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bầu", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1852), 500 },
                    { 7, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1853), "8.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bí đao", 8000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1853), 500 },
                    { 8, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1854), "8.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bí đỏ", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1855), 500 },
                    { 9, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1856), "9.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bí ngòi", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1857), 500 },
                    { 10, 5, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1858), "10.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bông bí", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1858), 500 },
                    { 11, 5, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1859), "11.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bông hẹ", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1860), 500 },
                    { 12, 5, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1861), "12.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bông so đũa", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1861), 500 },
                    { 13, 5, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1862), "13.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Bông thiên lý", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1862), 500 },
                    { 14, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1863), "14.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cà chua", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1864), 500 },
                    { 15, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1865), "15.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cà pháo", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1865), 500 },
                    { 16, 2, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1866), "6.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cà rốt", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1866), 500 },
                    { 17, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1867), "17.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cà tím", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1869), 500 },
                    { 18, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1870), "18.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải bẹ dưa", 5000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1870), 500 },
                    { 19, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1871), "19.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải bẹ dún", 5000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1871), 500 },
                    { 20, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1872), "20.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải bẹ xanh", 5000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1873), 500 },
                    { 21, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1874), "21.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải bó xôi", 15000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1874), 500 },
                    { 22, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1875), "22.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải ngọt", 5000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1875), 500 },
                    { 23, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1876), "23.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải thảo", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1877), 500 },
                    { 24, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1878), "24.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cải xà lách", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1878), 500 },
                    { 25, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1879), "25.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Xà lách tím", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1879), 500 },
                    { 26, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1880), "26.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Xà lách xoang", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1881), 500 },
                    { 27, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1881), "27.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Xà lách lụa", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1882), 500 },
                    { 28, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1883), "28.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cần dày lá", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1883), 500 },
                    { 29, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1885), "29.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cần tây", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1885), 500 },
                    { 30, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1886), "30.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Cần ô", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1887), 500 },
                    { 31, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1888), "31.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Chanh", 20000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1888), 500 },
                    { 32, 2, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1889), "32.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Củ cải trắng", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1889), 500 },
                    { 33, 2, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1890), "33.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Củ dền", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1891), 500 },
                    { 34, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1891), "34.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu bắp", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1892), 500 },
                    { 35, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1893), "35.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu đũa", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1893), 500 },
                    { 36, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1894), "36.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu Hà Lan", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1895), 500 },
                    { 37, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1896), "37.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu que", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1896), 500 },
                    { 38, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1897), "38.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu rồng", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1897), 500 }
                });

            migrationBuilder.InsertData(
                table: "Vegetables",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Image", "Location", "Name", "Price", "UpdatedDate", "Weight" },
                values: new object[] { 39, 1, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1898), "39.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Đậu ván", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1899), 500 });

            migrationBuilder.InsertData(
                table: "Vegetables",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Image", "Location", "Name", "Price", "UpdatedDate", "Weight" },
                values: new object[] { 40, 3, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1899), "40.jpg", "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long", "Dưa gan", 10000, new DateTime(2022, 7, 5, 18, 30, 23, 450, DateTimeKind.Local).AddTicks(1900), 500 });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "UserId", "VegetableId", "Amount" },
                values: new object[,]
                {
                    { new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"), 18, 2 },
                    { new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"), 24, 3 },
                    { new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"), 31, 1 },
                    { new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"), 40, 2 }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "Id", "Comment", "FeedbackTime", "UserId", "VegetableId", "Vote" },
                values: new object[,]
                {
                    { 1, "Rau tươi ngon", new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3682), new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"), 18, 5 },
                    { 2, "Rau héo", new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3684), new Guid("8a820adb-93d7-4c6f-9404-bdbfc14419f4"), 31, 3 },
                    { 3, "Rau tươi quá", new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3685), new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"), 24, 4 },
                    { 4, "Rau không tươi", new DateTime(2022, 7, 5, 18, 30, 23, 454, DateTimeKind.Local).AddTicks(3686), new Guid("51b4b238-4ae0-4e46-a3f4-e0acf7666b15"), 40, 2 }
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

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_UserId",
                table: "Feedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_VegetableId",
                table: "Feedbacks",
                column: "VegetableId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StatusId",
                table: "Orders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Vegetables_CategoryId",
                table: "Vegetables",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Vegetables");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
