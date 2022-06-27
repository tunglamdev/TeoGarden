﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.ShareModel.ViewModels
{
    public class FeedbackViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int VegetableId { get; set; }
        public string Comment { get; set; }
        public int Vote { get; set; }
        public DateTime? FeedbackTime { get; set; }
    }
}