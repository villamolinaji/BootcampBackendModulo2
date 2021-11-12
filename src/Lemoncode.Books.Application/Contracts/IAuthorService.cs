using Lemoncode.Books.Application.Models;

namespace Lemoncode.Books.Application.Contracts
{
    public interface IAuthorService
    {
        public void AddAuthor(AuthorAdd authorAdd);
    }
}
