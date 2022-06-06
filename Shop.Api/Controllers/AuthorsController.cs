using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaCrud.Api.Core.Entities;
using PruebaTecnicaCrud.Api.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaCrud.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        public IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await _authorService.GetAllAuthors();
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public async Task<Author> GetAuthorById(int id)
        {
            return await _authorService.GetAuthorById(id);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public async Task CreateAuthor([FromBody] Author author)
        {
            await _authorService.CreateNewAuthor(author);
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public async Task UpdateAuthor([FromBody] Author author)
        {
            await _authorService.UpdateAuthor(author);
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAuthor(int id)
        {
            await _authorService.DeleteAuthor(id);
        }
    }
}
