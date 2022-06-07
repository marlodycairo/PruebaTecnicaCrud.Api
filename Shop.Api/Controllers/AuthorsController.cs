using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaCrud.Api.Core.DTOs.Authors;
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
        private readonly IMapper _mapper;

        public AuthorsController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        // GET: api/<AuthorsController>
        [HttpGet]
        public async Task<ActionResult<AuthorResponse>> GetAuthors()
        {
            var authors = await _authorService.GetAllAuthors();

            var lstAuthors = _mapper.Map<IEnumerable<AuthorResponse>>(authors);


            return Ok(lstAuthors);
        }

        // GET api/<AuthorsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorResponse>> GetAuthorById(int id)
        {
            var author = await _authorService.GetAuthorById(id);

            var authorObj = _mapper.Map<AuthorResponse>(author);

            return Ok(authorObj);
        }

        // POST api/<AuthorsController>
        [HttpPost]
        public async Task<ActionResult> CreateAuthor([FromBody] CreateAuthor author)
        {
            var objAuthor = _mapper.Map<Author>(author);

            await _authorService.CreateNewAuthor(objAuthor);

            return Ok(author);
        }

        // PUT api/<AuthorsController>/5
        [HttpPut("{id}")]
        public ActionResult UpdateAuthor([FromBody] UpdateAuthor author)
        {
            var objAuthor = _mapper.Map<Author>(author);

            _authorService.UpdateAuthor(objAuthor);

            return Ok();
        }

        // DELETE api/<AuthorsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAuthor(int id)
        {
            await _authorService.DeleteAuthor(id);

            return Ok();
        }
    }
}
