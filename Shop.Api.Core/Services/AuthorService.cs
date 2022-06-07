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
        public readonly IUnitOfWork _unitOfWork;

        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateNewAuthor(Author author
            )
        {
            await _unitOfWork.AuthorRepository.Add(author);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAuthor(int id)
        {
            await _unitOfWork.AuthorRepository.Delete(id);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            return await _unitOfWork.AuthorRepository.GetAll();
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await _unitOfWork.AuthorRepository.GetById(id);
        }

        public void UpdateAuthor(Author author)
        {
            _unitOfWork.AuthorRepository.Update(author);

            _unitOfWork.SaveChanges();
        }
    }
}
