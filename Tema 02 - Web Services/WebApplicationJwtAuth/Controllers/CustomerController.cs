using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationJwtAuth.Entities;
//using WebApplicationJwtAuth.Entities.Requests;
//using WebApplicationJwtAuth.Entities.Deposits;
using WebApplicationJwtAuth.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationJwtAuth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _customerRepository { get; set; }

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpPost("addCustomer")]
        public async Task<IActionResult> AddCustomer(CustomerAdd customer)
        {
            _customerRepository.AddCustomer(new Customer(customer));
            return Ok();
        }

        [HttpGet("getCustomer")]
        public async Task<IActionResult> GetCustomer()
        {
            var cars = _customerRepository.GetAllCustomers();
            return Ok(cars);
        }
    }
}
