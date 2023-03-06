using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class OrderItem : BaseEntity
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Book Book { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
