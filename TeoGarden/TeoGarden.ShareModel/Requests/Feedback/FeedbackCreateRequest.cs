using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.ShareModel.Requests.Feedback
{
    public class FeedbackCreateRequest
    {
        public int UserId { get; set; }
        public int VegetableId { get; set; }
        public string Comment { get; set; }
        public int Vote { get; set; }
    }
}
