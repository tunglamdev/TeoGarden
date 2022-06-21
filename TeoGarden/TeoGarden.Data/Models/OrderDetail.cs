using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.Data.Models
{
    internal class OrderDetail
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int VegetableId { get; set; }
        public Vegetable Vegetable { get; set; }
        public int Amount { get; set; }
        public int OrderPrice { get; set; }
    }
}
