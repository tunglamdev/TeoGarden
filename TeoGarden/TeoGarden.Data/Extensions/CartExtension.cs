using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.Extensions
{
    public static class CartExtension
    {
        public static void FillDataCart(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>().HasData(
                new Cart(){ UserId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4"), VegetableId = 18, Amount = 2 },
                new Cart(){ UserId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4"), VegetableId = 31, Amount = 1 },
                new Cart(){ UserId = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15"), VegetableId = 24, Amount = 3 },
                new Cart(){ UserId = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15"), VegetableId = 40, Amount = 2 }
            );
        }
    }
}
