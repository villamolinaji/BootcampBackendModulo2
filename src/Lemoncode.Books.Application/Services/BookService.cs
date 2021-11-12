using Lemoncode.Books.Application.Contracts;
using Lemoncode.Books.Application.Models;
using Lemoncode.Books.Application.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Lemoncode.Books.Application.Services
{
    public class BookService : IBookService
    {
        private readonly BooksDbContext _dbContext;
        public BookService(BooksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddBook(BookAdd bookAdd)
        {
            var book = MapUtil.MapBookAddToBook(bookAdd);

            // Validate that book does not already exist
            var bookByTitle = _dbContext.Books.FirstOrDefault(b => b.Title == book.Title);
            if (bookByTitle != null)
            {
                throw new InvalidOperationException($"Book {book.Title} already exists.");
            }

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }        

        public void UpdateBook(BookUpdate bookUpdate)
        {
            var book = MapUtil.MapBookUpdateToBook(bookUpdate);

            // Validate that book exist
            var bookToUpdate = _dbContext.Books.FirstOrDefault(b => b.Id == book.Id);
            if (bookToUpdate == null)
            {
                throw new KeyNotFoundException($"Book {book.Id} not found.");
            }

            // Validate that book does not already exist
            var bookByTitle = _dbContext.Books
                                .FirstOrDefault(b => b.Title == book.Title &&
                                    b.Id != book.Id);
            if (bookByTitle != null)
            {
                throw new InvalidOperationException($"Book {book.Title} already exists.");
            }

            bookToUpdate.Title = book.Title;
            bookToUpdate.Description = book.Description;
            
            _dbContext.SaveChanges();
        }

        public List<BookGet> GetBooks()
        {
            var books = _dbContext.Books
                            .Include(b => b.Author)
                            .ToList();

            var booksResult = new List<BookGet>();

            foreach(var book in books)
            {
                booksResult.Add(MapUtil.MapBookToBookGet(book));
            }

            return booksResult;
        }
    }
}
