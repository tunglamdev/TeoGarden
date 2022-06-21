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
                new Cart(){ UserId = 1, VegetableId = 18, Amount = 2 },
                new Cart(){ UserId = 1, VegetableId = 31, Amount = 1 },
                new Cart(){ UserId = 1, VegetableId = 24, Amount = 3 },
                new Cart(){ UserId = 2, VegetableId = 40, Amount = 2 }
            );
        }
    }
}
