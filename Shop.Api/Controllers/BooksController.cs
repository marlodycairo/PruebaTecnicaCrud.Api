using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaCrud.Api.Core.DTOs.Books;
using PruebaTecnicaCrud.Api.Core.Entities;
using PruebaTecnicaCrud.Api.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnicaCrud.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public readonly IBookService _bookService;
        public readonly IMapper _mapper;

        public BooksController(IBookService bookService, IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public async Task<ActionResult<BookResponse>> GetBooks()
        {
            var books = await _bookService.GetAllBooks();

            var lstBooks = _mapper.Map<IEnumerable<BookResponse>>(books);

            return Ok(lstBooks);
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BookResponse>>  GetBookById(int id)
        {
            var book = await _bookService.GetBookById(id);

            var bookObj = _mapper.Map<BookResponse>(book);

            return Ok(bookObj);
        }

        // POST api/<BooksController>
        [HttpPost]
        public async Task<ActionResult> CreateBook([FromBody] CreateBook book)
        {
            var objBook = _mapper.Map<Book>(book);

            await _bookService.CreateNewBook(objBook);

            return Ok(book);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public ActionResult UpdateBook([FromBody] UpdateBook book)
        {
            var objBook = _mapper.Map<Book>(book);

            _bookService.UpdateBook(objBook);

            return Ok();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            await _bookService.DeleteBook(id);

            return Ok();
        }
    }
}
