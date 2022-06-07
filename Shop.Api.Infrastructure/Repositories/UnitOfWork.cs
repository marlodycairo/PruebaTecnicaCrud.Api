using PruebaTecnicaCrud.Api.Core.Entities;
using PruebaTecnicaCrud.Api.Core.Interfaces;
using Shop.Api.Core.Interfaces;
using Shop.Api.Infrastructure.Context;
using Shop.Api.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppShopDbContext _context;
        private readonly IRepository<Author> _authorRepository;
        private readonly IRepository<Book> _bookRepository;

        public UnitOfWork(AppShopDbContext context)
        {
            _context = context;
        }

        public IRepository<Author> AuthorRepository => _authorRepository ?? new BaseRepository<Author>(_context);
        public IRepository<Book> BookRepository => _bookRepository ?? new BaseRepository<Book>(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
