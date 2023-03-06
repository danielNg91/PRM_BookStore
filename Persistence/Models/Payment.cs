using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Payment : BaseEntity
    {
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentTotal { get; set; }
        public string PaymentMethod { get; set; } = null!;
        public string PaymentStatus { get; set; } = null!;

        public virtual User Customer { get; set; } = null!;
        public virtual Order Order { get; set; } = null!;
    }
}
