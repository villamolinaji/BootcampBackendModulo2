using Lemoncode.Books.Application.Models;
using System.Collections.Generic;

namespace Lemoncode.Books.Application.Contracts
{
    public interface IBookService
    {
        public BookAdd AddBook(BookAdd bookAdd);
        public void UpdateBook(BookUpdate bookUpdate);

        public List<BookGet> GetBooks();
        public List<BookGet> GetBooksByTitle(string title);
        public List<BookGet> GetBooksByTitleAndAuthorName(string title, string authorName);
    }
}
