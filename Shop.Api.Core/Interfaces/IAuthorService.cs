using PruebaTecnicaCrud.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Core.Interfaces
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<Author> GetAuthorById(int id);
        Task CreateNewAuthor(Author entity);
        void UpdateAuthor(Author entity);
        Task DeleteAuthor(int id);
    }
}
