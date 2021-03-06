using System;
using System.ComponentModel.DataAnnotations;

namespace Lemoncode.Books.Application.Models
{
    public class BookAdd
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Description { get; set; }
        [Required]
        public int AuthorId { get; set; }
    }
}
