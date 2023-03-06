using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Book : BaseEntity
    {
        public Book()
        {
            OrderItems = new HashSet<OrderItem>();
            Genres = new HashSet<Genre>();
        }

        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual ICollection<Genre> Genres { get; set; }
    }
}
