using System;

namespace Lemoncode.Books.Application.Models
{
    public class BookAdd
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
    }
}
