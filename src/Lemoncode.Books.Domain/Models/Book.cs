using System;

namespace Lemoncode.Books.Domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }

        // navigation property
        public Author Author { get; set; } = new Author();
    }
}
