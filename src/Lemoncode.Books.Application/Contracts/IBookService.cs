using Lemoncode.Books.Application.Models;

namespace Lemoncode.Books.Application.Contracts
{
    public interface IBookService
    {
        public void AddBook(BookAdd book);
    }
}
