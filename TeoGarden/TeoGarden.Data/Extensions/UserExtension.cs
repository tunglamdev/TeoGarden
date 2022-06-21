using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.Extensions
{
    public static class UserExtension
    {
        public static void FillDataUser(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Name = "Nguyễn Tùng Lâm",
                    Email = "lam@gmail.com",
                    Phone = "0338307449",
                    Address = "Cộng Hòa, Q.Tân Bình, TP.HCM",
                    Avatar = "lam.jpg",
                    Role = 0,
                    Password = "12345"
                },
                new User()
                {
                    Id = 2,
                    Name = "Nguyễn Văn An",
                    Email = "an@gmail.com",
                    Phone = "0338307449",
                    Address = "Phan Đăng Lưu, Q.Phú Nhuận, TP.HCM",
                    Avatar = "an.jpg",
                    Role = 0,
                    Password = "12345"
                },
                new User()
                {
                    Id = 3,
                    Name = "Jonson Admin",
                    Email = "admin@gmail.com",
                    Phone = "0338307449",
                    Address = "Califonia, Hoa Kỳ",
                    Avatar = "admin.jpg",
                    Role = 1,
                    Password = "12345"
                }
            );
        }
    }
}
