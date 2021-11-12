using Lemoncode.Books.Application.Contracts;
using Lemoncode.Books.Application.Models;
using Lemoncode.Books.Application.Utilities;
using System;
using System.Linq;

namespace Lemoncode.Books.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly BooksDbContext _dbContext;
        public AuthorService(BooksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddAuthor(AuthorAdd authorAdd)
        {
            var author = MapUtil.MapAuthorAddToAuthor(authorAdd);

            // Validate that author does not already exist
            var authorByName = _dbContext.Authors
                                .FirstOrDefault(a => a.LastName == author.LastName &&
                                    a.Name == author.Name);
            if (authorByName != null)
            {
                throw new InvalidOperationException($"Author {author.Name} {author.LastName} already exists.");
            }

            _dbContext.Authors.Add(author);
            _dbContext.SaveChanges();
        }        
    }
}
