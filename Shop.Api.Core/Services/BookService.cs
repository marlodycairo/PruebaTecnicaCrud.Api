using PruebaTecnicaCrud.Api.Core.Entities;
using PruebaTecnicaCrud.Api.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Core.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateNewBook(Book book)
        {
            await _unitOfWork.BookRepository.Add(book);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteBook(int id)
        {
            await _unitOfWork.BookRepository.Delete(id);

            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _unitOfWork.BookRepository.GetAll();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _unitOfWork.BookRepository.GetById(id);
        }

        public void UpdateBook(Book book)
        {
            _unitOfWork.BookRepository.Update(book);

            _unitOfWork.SaveChanges();
        }
    }
}
