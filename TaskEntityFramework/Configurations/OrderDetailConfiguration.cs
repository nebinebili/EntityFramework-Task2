using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEntityFramework.Models;

namespace TaskEntityFramework.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Ignore(o => o.Id);
            builder.HasKey(o => new { o.OrderId, o.ProductId });

            // Order(many) and Product(many)

            //builder.HasOne(od => od.Product)
            //       .WithMany(p => p.OrderDetails)
            //       .HasForeignKey(od => od.ProductId);

            //builder.HasOne(od => od.Order)
            //       .WithMany(o => o.OrderDetails)
            //       .HasForeignKey(od => od.OrderId);
        }
    }
}
