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
                new Order(){ Id = 1, UserId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4"), StatusId = 1, OrderTime = DateTime.Now, DeliveryTime = DateTime.Now},
                new Order(){ Id = 2, UserId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4"), StatusId = 2, OrderTime = DateTime.Now, DeliveryTime = DateTime.Now},
                new Order(){ Id = 3, UserId = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15"), StatusId = 3, OrderTime = DateTime.Now, DeliveryTime = DateTime.Now},
                new Order(){ Id = 4, UserId = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15"), StatusId = 1, OrderTime = DateTime.Now, DeliveryTime = DateTime.Now}
            );
        }
    }
}
