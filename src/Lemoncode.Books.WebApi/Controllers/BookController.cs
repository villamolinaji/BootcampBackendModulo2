using Lemoncode.Books.Application.Contracts;
using Lemoncode.Books.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Lemoncode.Books.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BookController
            : ControllerBase
    {

        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public IActionResult AddBook(BookAdd bookAdd)
        {
            try
            {
                _bookService.AddBook(bookAdd);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
