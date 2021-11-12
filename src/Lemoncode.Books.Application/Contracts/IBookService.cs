using Lemoncode.Books.Application.Models;
using System.Collections.Generic;

namespace Lemoncode.Books.Application.Contracts
{
    public interface IBookService
    {
        public void AddBook(BookAdd bookAdd);
        public void UpdateBook(BookUpdate bookUpdate);

        public List<BookGet> GetBooks();
    }
}
