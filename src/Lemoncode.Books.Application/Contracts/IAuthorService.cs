using Lemoncode.Books.Application.Models;

namespace Lemoncode.Books.Application.Contracts
{
    public interface IAuthorService
    {
        public AuthorAdd AddAuthor(AuthorAdd authorAdd);

        public AuthorGet GetAuthorById(int id);
    }
}
