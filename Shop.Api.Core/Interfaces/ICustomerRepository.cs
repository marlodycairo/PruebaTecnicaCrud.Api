using Shop.Api.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Api.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetById(int id);
        Task Add(Customer entity);
        Task Update(Customer entity);
        Task Delete(int id);
    }
}
