using Lemoncode.Books.Application.Contracts;
using Lemoncode.Books.Application.Models;

namespace Lemoncode.Books.Application.Services
{
    public class BookService : IBookService
    {
        private readonly BooksDbContext _dbContext;
        public BookService(BooksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBook(BookAdd book)
        { 
        }
    }
}
