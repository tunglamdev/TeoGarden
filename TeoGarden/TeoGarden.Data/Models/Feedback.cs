using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.Data.Models
{
    internal class Feedback
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int VegetableId { get; set; }
        public Vegetable Vegetable { get; set; }
        public int Amount { get; set; }
    }
}
