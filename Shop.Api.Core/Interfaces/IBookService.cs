using PruebaTecnicaCrud.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Core.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
        Task CreateNewBook(Book entity);
        void UpdateBook(Book entity);
        Task DeleteBook(int id);
    }
}
