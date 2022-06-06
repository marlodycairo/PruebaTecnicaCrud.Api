using Microsoft.EntityFrameworkCore;
using PruebaTecnicaCrud.Api.Core.Entities;
using Shop.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Api.Infrastructure.Context
{
    public class AppShopDbContext : DbContext
    {
        public AppShopDbContext(DbContextOptions<AppShopDbContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
