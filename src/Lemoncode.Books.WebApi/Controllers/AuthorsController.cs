using Lemoncode.Books.Application.Contracts;
using Lemoncode.Books.Application.Models;
using Lemoncode.Books.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemoncode.Books.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost]
        public IActionResult AddAuthor(AuthorAdd authorAdd)
        {
            try
            {
                _authorService.AddAuthor(authorAdd);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<Author> GetAuthor(int id)
        {
            return _authorService.GetAuthorById(id);
        }
    }
}
