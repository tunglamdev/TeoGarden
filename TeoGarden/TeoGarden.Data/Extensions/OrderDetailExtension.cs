using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.Extensions
{
    public static class OrderDetailExtension
    {
        public static void FillDataOrderDetail(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail(){ OrderId = 1, VegetableId = 1,     Amount = 2, OrderPrice = 5000  },
                new OrderDetail(){ OrderId = 1, VegetableId = 10,    Amount = 1, OrderPrice = 15000 },
                new OrderDetail(){ OrderId = 1, VegetableId = 26,    Amount = 2, OrderPrice = 10000 },
                new OrderDetail(){ OrderId = 2, VegetableId = 8,     Amount = 3, OrderPrice = 10000 },
                new OrderDetail(){ OrderId = 2, VegetableId = 40,    Amount = 2, OrderPrice = 15000 },
                new OrderDetail(){ OrderId = 3, VegetableId = 33,    Amount = 2, OrderPrice = 15000 },
                new OrderDetail(){ OrderId = 4, VegetableId = 28,    Amount = 2, OrderPrice = 5000  }
            );
        }
    }
}
