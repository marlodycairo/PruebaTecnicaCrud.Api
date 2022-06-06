using Shop.Api.Core.Entities;
using Shop.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Api.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task DeleteCustomer(int id)
        {
            await _customerRepository.Delete(id);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _customerRepository.GetAll();
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _customerRepository.GetById(id);
        }

        public async Task InsertCustomer(Customer entity)
        {
            await _customerRepository.Add(entity);
        }

        public async Task UpdateCustomer(Customer entity)
        {
            await _customerRepository.Update(entity);
        }
    }
}
