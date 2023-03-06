using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context.EntityTypeConfigurations;
public class PaymentEntityTypeConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder
            .HasOne(e => e.Customer)
            .WithMany(e => e.Payments)
            .HasForeignKey(e => e.CustomerId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
