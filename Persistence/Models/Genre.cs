using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Genre : BaseEntity
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        public string GenreName { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
