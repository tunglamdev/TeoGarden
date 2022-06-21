using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.Extensions
{
    public static class FeedbackExtension
    {
        public static void FillDataFeedback(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback() { Id = 1, UserId = 1, VegetableId = 18, Comment = "Rau tươi ngon", Vote = 5, FeedbackTime = DateTime.Now },
                new Feedback() { Id = 2, UserId = 1, VegetableId = 31, Comment = "Rau héo", Vote = 3, FeedbackTime = DateTime.Now },
                new Feedback() { Id = 3, UserId = 2, VegetableId = 24, Comment = "Rau tươi quá", Vote = 4, FeedbackTime = DateTime.Now },
                new Feedback() { Id = 4, UserId = 2, VegetableId = 40, Comment = "Rau không tươi", Vote = 2, FeedbackTime = DateTime.Now }
            );
        }
    }
}
