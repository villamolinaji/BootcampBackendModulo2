namespace Lemoncode.Books.Application.Models
{
    public class BookGet
    {
        public int Id { get; set; }        
        public string Title { get; set; }
        public string Description { get; set; }
        public string PublishedOn { get; set; }
        public string AuthorFullName { get; set; }
    }
}
