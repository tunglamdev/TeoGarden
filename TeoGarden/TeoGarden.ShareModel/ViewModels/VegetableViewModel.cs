using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.ShareModel.ViewModels
{
    public class VegetableViewModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public int Sale { get; set; }
        public int CategoryId { get; set; }
        public string Location { get; set; }
    }
}
