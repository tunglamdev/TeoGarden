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
                new Feedback() { Id = 1, UserId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4"), VegetableId = 18, Comment = "Rau tươi ngon", Vote = 5, FeedbackTime = DateTime.Now },
                new Feedback() { Id = 2, UserId = new Guid("8A820ADB-93D7-4C6F-9404-BDBFC14419F4"), VegetableId = 31, Comment = "Rau héo", Vote = 3, FeedbackTime = DateTime.Now },
                new Feedback() { Id = 3, UserId = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15"), VegetableId = 24, Comment = "Rau tươi quá", Vote = 4, FeedbackTime = DateTime.Now },
                new Feedback() { Id = 4, UserId = new Guid("51B4B238-4AE0-4E46-A3F4-E0ACF7666B15"), VegetableId = 40, Comment = "Rau không tươi", Vote = 2, FeedbackTime = DateTime.Now }
            );
        }
    }
}
