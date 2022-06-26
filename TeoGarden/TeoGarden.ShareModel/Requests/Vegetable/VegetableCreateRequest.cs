using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.ShareModel.Requests.Vegetable
{
    public class VegetableCreateRequest
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public string Image { get; set; }
        public string Location { get; set; }
        public int CategoryId { get; set; }
    }
}
