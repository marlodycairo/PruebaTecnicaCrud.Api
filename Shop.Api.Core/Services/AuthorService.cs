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

        public async Task CreateNewAuthor(Author author
            )
        {
            await _authorRepository.Add(author);
        }

        public async Task DeleteAuthor(int id)
        {
            await _authorRepository.Delete(id);
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _authorRepository.GetAll();
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await _authorRepository.GetById(id);
        }

        public async Task UpdateAuthor(Author author)
        {
            await _authorRepository.Update(author);
        }
    }
}
