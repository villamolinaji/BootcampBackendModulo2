using Lemoncode.Books.Application.Models;
using Lemoncode.Books.Domain.Models;

namespace Lemoncode.Books.Application.Contracts
{
    public interface IAuthorService
    {
        public void AddAuthor(AuthorAdd authorAdd);

        public Author GetAuthorById(int id);
    }
}
