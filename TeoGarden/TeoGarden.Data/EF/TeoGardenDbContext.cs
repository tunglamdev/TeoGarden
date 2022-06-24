using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Configurations;
using TeoGarden.Data.Extensions;
using TeoGarden.Data.Models;
using System.IO;

namespace TeoGarden.Data.EF
{
    public class TeoGardenDbContext : DbContext
    {
        public DbSet<Vegetable> Vegetables { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        public DbSet<Cart> Carts { set; get; }
        public DbSet<Feedback> Feedbacks { set; get; }
        public DbSet<Status> Statuses { set; get; }
        public TeoGardenDbContext(DbContextOptions<TeoGardenDbContext> options)
            : base(options)
        {
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
