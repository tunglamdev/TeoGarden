using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.Extensions
{
    public static class VegetableExtension
    {
        public static void FillDataVegetable(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vegetable>().HasData(
                new Vegetable()
                {
                    Id = 1,
                    Name = "Bạc hà",
                    Weight = 500,
                    Price = 10000,
                    Image = "1.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 2,
                    Name = "Bắp cải tím",
                    Weight = 500,
                    Price = 15000,
                    Image = "2.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 3,
                    Name = "Bắp cải trắng",
                    Weight = 500,
                    Price = 15000,
                    Image = "3.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 4,
                    Name = "Bắp chuối bào",
                    Weight = 500,
                    Price = 10000,
                    Image = "4.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 5,
                    Name = "Bắp non",
                    Weight = 500,
                    Price = 25000,
                    Image = "5.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 6,
                    Name = "Bầu",
                    Weight = 500,
                    Price = 10000,
                    Image = "6.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 7,
                    Name = "Bí đao",
                    Weight = 500,
                    Price = 8000,
                    Image = "8.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 8,
                    Name = "Bí đỏ",
                    Weight = 500,
                    Price = 10000,
                    Image = "8.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 9,
                    Name = "Bí ngòi",
                    Weight = 500,
                    Price = 10000,
                    Image = "9.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 10,
                    Name = "Bông bí",
                    Weight = 500,
                    Price = 10000,
                    Image = "10.jpg",
                    CategoryId = 5,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 11,
                    Name = "Bông hẹ",
                    Weight = 500,
                    Price = 10000,
                    Image = "11.jpg",
                    CategoryId = 5,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 12,
                    Name = "Bông so đũa",
                    Weight = 500,
                    Price = 10000,
                    Image = "12.jpg",
                    CategoryId = 5,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 13,
                    Name = "Bông thiên lý",
                    Weight = 500,
                    Price = 10000,
                    Image = "13.jpg",
                    CategoryId = 5,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 14,
                    Name = "Cà chua",
                    Weight = 500,
                    Price = 10000,
                    Image = "14.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 15,
                    Name = "Cà pháo",
                    Weight = 500,
                    Price = 10000,
                    Image = "15.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 16,
                    Name = "Cà rốt",
                    Weight = 500,
                    Price = 10000,
                    Image = "6.jpg",
                    CategoryId = 2,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 17,
                    Name = "Cà tím",
                    Weight = 500,
                    Price = 10000,
                    Image = "17.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 18,
                    Name = "Cải bẹ dưa",
                    Weight = 500,
                    Price = 5000,
                    Image = "18.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 19,
                    Name = "Cải bẹ dún",
                    Weight = 500,
                    Price = 5000,
                    Image = "19.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 20,
                    Name = "Cải bẹ xanh",
                    Weight = 500,
                    Price = 5000,
                    Image = "20.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 21,
                    Name = "Cải bó xôi",
                    Weight = 500,
                    Price = 15000,
                    Image = "21.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 22,
                    Name = "Cải ngọt",
                    Weight = 500,
                    Price = 5000,
                    Image = "22.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 23,
                    Name = "Cải thảo",
                    Weight = 500,
                    Price = 10000,
                    Image = "23.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 24,
                    Name = "Cải xà lách",
                    Weight = 500,
                    Price = 10000,
                    Image = "24.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 25,
                    Name = "Xà lách tím",
                    Weight = 500,
                    Price = 10000,
                    Image = "25.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 26,
                    Name = "Xà lách xoang",
                    Weight = 500,
                    Price = 10000,
                    Image = "26.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 27,
                    Name = "Xà lách lụa",
                    Weight = 500,
                    Price = 10000,
                    Image = "27.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 28,
                    Name = "Cần dày lá",
                    Weight = 500,
                    Price = 10000,
                    Image = "28.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 29,
                    Name = "Cần tây",
                    Weight = 500,
                    Price = 10000,
                    Image = "29.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 30,
                    Name = "Cần ô",
                    Weight = 500,
                    Price = 10000,
                    Image = "30.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 31,
                    Name = "Chanh",
                    Weight = 500,
                    Price = 20000,
                    Image = "31.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 32,
                    Name = "Củ cải trắng",
                    Weight = 500,
                    Price = 10000,
                    Image = "32.jpg",
                    CategoryId = 2,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 33,
                    Name = "Củ dền",
                    Weight = 500,
                    Price = 10000,
                    Image = "33.jpg",
                    CategoryId = 2,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 34,
                    Name = "Đậu bắp",
                    Weight = 500,
                    Price = 10000,
                    Image = "34.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 35,
                    Name = "Đậu đũa",
                    Weight = 500,
                    Price = 10000,
                    Image = "35.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 36,
                    Name = "Đậu Hà Lan",
                    Weight = 500,
                    Price = 10000,
                    Image = "36.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 37,
                    Name = "Đậu que",
                    Weight = 500,
                    Price = 10000,
                    Image = "37.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 38,
                    Name = "Đậu rồng",
                    Weight = 500,
                    Price = 10000,
                    Image = "38.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 39,
                    Name = "Đậu ván",
                    Weight = 500,
                    Price = 10000,
                    Image = "39.jpg",
                    CategoryId = 1,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                },
                new Vegetable()
                {
                    Id = 40,
                    Name = "Dưa gan",
                    Weight = 500,
                    Price = 10000,
                    Image = "40.jpg",
                    CategoryId = 3,
                    Location = "Tổng công ty rau quả nông sản, cánh đồng nông sản sạch, xã Hòa Bình, huyện Trà Ôn, tỉnh Vĩnh Long",
                    Sale = 0
                }
            );

        }
    }
}
