using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeoGarden.Data.Models;

namespace TeoGarden.Data.Configurations
{
    public class VegetableConfig : IEntityTypeConfiguration<Vegetable>
    {
        public void Configure(EntityTypeBuilder<Vegetable> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Weight).IsRequired();
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.IsSale).HasDefaultValue(false);
            builder.Property(x => x.Location).IsRequired(); 
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
        }
    }
}
