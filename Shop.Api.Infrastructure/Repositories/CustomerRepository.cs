using Microsoft.EntityFrameworkCore;
using Shop.Api.Core.Entities;
using Shop.Api.Core.Interfaces;
using Shop.Api.Infrastructure.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Api.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppShopDbContext _context;

        public CustomerRepository(AppShopDbContext context)
        {
            _context = context;
        }

        public async Task Add(Customer entity)
        {
            await _context.Customers.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var customer = await GetById(id);

            _context.Remove(customer);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task Update(Customer entity)
        {
            _context.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
