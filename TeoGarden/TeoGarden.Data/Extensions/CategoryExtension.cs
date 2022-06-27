using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.Extensions
{
    public static class CategoryExtension
    {
        public static void FillDataCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category(){ Id = 1,     Name = "Rau",   Image = "1.jpg", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Category(){ Id = 2,     Name = "Củ",    Image = "2.jpg", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Category(){ Id = 3,     Name = "Quả",   Image = "3.jpg", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Category(){ Id = 4,     Name = "Nấm",   Image = "4.jpg", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Category(){ Id = 5,     Name = "Bông",  Image = "5.jpg", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now },
                new Category(){ Id = 6,     Name = "Hạt",   Image = "6.jpg", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now }
            );
        }
    }
}
