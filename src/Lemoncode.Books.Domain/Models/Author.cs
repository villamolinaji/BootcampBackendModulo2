using System;
using System.Collections.Generic;

namespace Lemoncode.Books.Domain.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string CountyrCode { get; set; }

        // navigation property
        public List<Book> Books { get; set; }

    }
}
