using Lemoncode.Books.Application.Contracts;
using Lemoncode.Books.Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;

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
        public ActionResult<AuthorAdd> AddAuthor(AuthorAdd authorAdd)
        {
            try
            {
                var authorAdded = _authorService.AddAuthor(authorAdd);
                return Ok(authorAdded);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<AuthorGet> GetAuthor(int id)
        {
            return _authorService.GetAuthorById(id);
        }
    }
}
