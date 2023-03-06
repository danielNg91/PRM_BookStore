using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class User : BaseEntity
    {
        public User()
        {
            Orders = new HashSet<Order>();
            Payments = new HashSet<Payment>();
        }

        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public bool IsRegistered { get; set; }
        public bool IsAdmin { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
