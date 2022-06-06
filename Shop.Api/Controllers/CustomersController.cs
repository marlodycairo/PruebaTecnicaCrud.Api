using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Shop.Api.Core.DTOs;
using Shop.Api.Core.Entities;
using Shop.Api.Core.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _customerService.GetAllCustomers();

            var objCustomers = _mapper.Map<IEnumerable<CustomerDto>>(customers);

            return Ok(objCustomers);
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _customerService.GetCustomerById(id);

            var objCustomer = _mapper.Map<CustomerDto>(customer);

            return Ok(objCustomer);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerDto value)
        {
            var objCustomer = _mapper.Map<Customer>(value);

            await _customerService.InsertCustomer(objCustomer);

            return Ok(value);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer([FromBody] CustomerDto value)
        {
            var objCustomer = _mapper.Map<Customer>(value);
            
            await _customerService.UpdateCustomer(objCustomer);

            return Ok(value);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var objCustomer = _mapper.Map<Customer>(id);

            await _customerService.DeleteCustomer(objCustomer.CustomerID);
        }
    }
}
