using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Configurations;
using TeoGarden.Data.Extensions;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.EF
{
    public class TeoGardenDbContext : DbContext
    {
        DbSet<Vegetable> Vegetables { set; get; }
        DbSet<Category> Categories { set; get; }
        DbSet<User> Users { set; get; }
        DbSet<Order> Orders { set; get; }
        DbSet<OrderDetail> OrderDetails { set; get; }
        DbSet<Cart> Carts { set; get; }
        DbSet<Feedback> Feedbacks { set; get; }
        DbSet<Status> Statuses { set; get; }

        private const string connectionString = "Data Source=TUNGLAM\\SQLEXPRESS; Initial Catalog=TeoGarden; Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API in config file
            modelBuilder
                .ApplyConfiguration(new OrderConfig())
                .ApplyConfiguration(new CartConfig())
                .ApplyConfiguration(new OrderDetailConfig())
                .ApplyConfiguration(new UserConfig())
                .ApplyConfiguration(new VegetableConfig())
                .ApplyConfiguration(new CategoryConfig())
                .ApplyConfiguration(new FeedbackConfig())
                .ApplyConfiguration(new StatusConfig());

            // Data seeding in ModelBuilderExtenions
            modelBuilder.FillDataVegetable();
            modelBuilder.FillDataCategory();
            modelBuilder.FillDataUser();
            modelBuilder.FillDataCart();
            modelBuilder.FillDataOrder();
            modelBuilder.FillDataOrderDetail();
            modelBuilder.FillDataStatus();
            modelBuilder.FillDataFeedback();
        }
    }
}
