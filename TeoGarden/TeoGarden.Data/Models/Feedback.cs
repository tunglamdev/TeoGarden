using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.Data.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int VegetableId { get; set; }
        public Vegetable Vegetable { get; set; }
        public string Comment { get; set; }
        public int Vote { get; set; }
        public DateTime? FeedbackTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
