using PruebaTecnicaCrud.Api.Core.Entities;
using Shop.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Author> AuthorRepository { get; }
        IRepository<Book> BookRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
    }
}
