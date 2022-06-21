using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.Extensions
{
    public static class StatusExtension
    {
        public static void FillDataStatus(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasData(
                new Status(){ Id = 1, Name = "Chưa xử lý" },
                new Status(){ Id = 2, Name = "Đang chuẩn bị" },
                new Status(){ Id = 3, Name = "Đang giao hàng" },
                new Status(){ Id = 4, Name = "Đã giao hàng" }
            );
        }
    }
}
