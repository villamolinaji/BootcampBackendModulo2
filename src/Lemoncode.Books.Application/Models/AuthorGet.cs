using System;

namespace Lemoncode.Books.Application.Models
{
    public class AuthorGet
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string FullName 
        {
            get 
            {
                return $"{Name} {LastName}";
            }
        }
        
        public string CountyrCode { get; set; }
    }
}
