using System;
using System.ComponentModel.DataAnnotations;

namespace Lemoncode.Books.Application.Models
{
    public class AuthorAdd
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        
        [StringLength(2)]
        public string CountyrCode { get; set; }
    }
}
