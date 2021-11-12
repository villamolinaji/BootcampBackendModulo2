using Lemoncode.Books.Application.Models;
using Lemoncode.Books.Domain.Models;

namespace Lemoncode.Books.Application.Utilities
{
    public static class MapUtil
    {
        public static Author MapAuthorAddToAuthor(AuthorAdd authorAdd)
        {
            return new Author
            {
                Birth = authorAdd.Birth,
                CountyrCode = authorAdd.CountyrCode,
                LastName = authorAdd.LastName,
                Name = authorAdd.Name
            };
        }

        public static Book MapBookAddToBook(BookAdd bookAdd)
        {
            return new Book
            {
                AuthorId = bookAdd.AuthorId,
                Description = bookAdd.Description,
                PublishedOn = bookAdd.PublishedOn,
                Title = bookAdd.Title
            };
        }

        public static Book MapBookUpdateToBook(BookUpdate bookUpdate)
        {
            return new Book
            {
                Id = bookUpdate.Id,
                Description = bookUpdate.Description,                
                Title = bookUpdate.Title
            };
        }

        public static BookGet MapBookToBookGet(Book book)
        {
            return new BookGet
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                PublishedOn = book.PublishedOn.ToString("o"),
                AuthorFullName = $"{book.Author.Name} {book.Author.LastName}"
            };
        }
    }
}
