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
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TeoGarden.Data.EF
{
    public class TeoGardenDbContext : IdentityDbContext<User, UserRole, Guid>
    {
        public DbSet<Vegetable> Vegetables { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<UserRole> UserRole { set; get; }
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

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

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
