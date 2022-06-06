using PruebaTecnicaCrud.Api.Core.Entities;
using PruebaTecnicaCrud.Api.Core.Interfaces;
using Shop.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Core.Services
{
    public class AuthorService : IAuthorService
    {
        public IRepository<Author> _authorRepository;
        public AuthorService(IRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task CreateNewAuthor(Author entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Author>> GetAllAuthors()
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetAuthorById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAuthor(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
