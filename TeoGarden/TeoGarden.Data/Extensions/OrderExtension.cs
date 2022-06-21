using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.Extensions
{
    public static class OrderExtension
    {
        public static void FillDataOrder(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order(){ Id = 1, UserId = 1, StatusId = 1, OrderTime = DateTime.Now, DeliveryTime = DateTime.Now},
                new Order(){ Id = 2, UserId = 1, StatusId = 2, OrderTime = DateTime.Now, DeliveryTime = DateTime.Now},
                new Order(){ Id = 3, UserId = 1, StatusId = 3, OrderTime = DateTime.Now, DeliveryTime = DateTime.Now},
                new Order(){ Id = 4, UserId = 2, StatusId = 1, OrderTime = DateTime.Now, DeliveryTime = DateTime.Now}
            );
        }
    }
}
