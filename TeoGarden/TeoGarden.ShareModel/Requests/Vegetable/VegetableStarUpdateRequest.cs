using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.ShareModel.Requests.Vegetable
{
    public class VegetableStarUpdateRequest
    {
        public int VegetableId { get; set; }
        public double Stars { get; set; }
    }
}
