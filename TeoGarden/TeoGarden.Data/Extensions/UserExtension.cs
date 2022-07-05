using Microsoft.AspNetCore.Identity;
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
            var adminRoleId = new Guid("9E87B492-5343-4272-9A34-FA5DE7CFFB22");
            var userRoleId = new Guid("8F7579EE-4AF9-4B71-9ADA-7F792F76DC31");
            var adminId = new Guid("372EA575-2536-4076-9BAB-3E3138DE495F");
            var userId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4");
            var userId2 = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15");

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    Id = adminRoleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                },
                  new UserRole
                  {
                      Id = userRoleId,
                      Name = "customer",
                      NormalizedName = "customer",
                      Description = "Customer role"
                  }
            );

            var hasher = new PasswordHasher<User>();
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = userId,
                    Name = "Nguyễn Tùng Lâm",
                    Email = "lam@gmail.com",
                    Phone = "0338307449",
                    Address = "Cộng Hòa, Q.Tân Bình, TP.HCM",
                    Avatar = "lam.jpg",
                    Password = hasher.HashPassword(null, "Abcd1234!")
                },
                new User()
                {
                    Id = userId2,
                    Name = "Nguyễn Văn An",
                    Email = "an@gmail.com",
                    Phone = "0338307449",
                    Address = "Phan Đăng Lưu, Q.Phú Nhuận, TP.HCM",
                    Avatar = "an.jpg",
                    Password = hasher.HashPassword(null, "Abcd1234!")
                },
                new User()
                {
                    Id = adminId,
                    Name = "John",
                    Email = "admin@gmail.com",
                    Phone = "0338307449",
                    Address = "Califonia, Hoa Kỳ",
                    Avatar = "admin.jpg",
                    Password = hasher.HashPassword(null, "Abcd1234!")
                    //IsAdmin = hasher.HashPassword(null, "Abcd1234!")
                }
            );

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
              new IdentityUserRole<Guid>
              {
                  RoleId = adminRoleId,
                  UserId = adminId,
              },
              new IdentityUserRole<Guid>
              {
                  RoleId = userRoleId,
                  UserId = userId,
              },
              new IdentityUserRole<Guid>
              {
                  RoleId = userRoleId,
                  UserId = userId2,
              });
        }
    }
}
