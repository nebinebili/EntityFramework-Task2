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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Ignore(o => o.Id);
            builder.HasKey(o => new { o.CustomerId, o.EmployeeId });

            //Customer(many) to Employee(many)

            //builder.HasOne(o => o.Customer)
            //       .WithMany(c => c.Orders)
            //       .HasForeignKey(o => o.CustomerId);

            //builder.HasOne(o => o.Employee)
            //       .WithMany(e => e.Orders)
            //       .HasForeignKey(o => o.EmployeeId);
        }
    }
}
