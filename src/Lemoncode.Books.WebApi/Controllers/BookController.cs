using Lemoncode.Books.Application.Contracts;
using Lemoncode.Books.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Lemoncode.Books.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class BookController : ControllerBase
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

        [HttpPut]
        public IActionResult UpdateBook(BookUpdate bookUpdate)
        {
            try
            {
                _bookService.UpdateBook(bookUpdate);
                return Ok();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<BookGet>> Get()
        {
            return _bookService.GetBooks();
        }
    }
}
