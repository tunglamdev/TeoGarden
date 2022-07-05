using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.ShareModel.ViewModels
{
    public class FeedbackViewModel
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public int VegetableId { get; set; }
        public string Comment { get; set; }
        [Range(1, 5)]
        public int Vote { get; set; }
        public DateTime? FeedbackTime { get; set; }
    }
}
