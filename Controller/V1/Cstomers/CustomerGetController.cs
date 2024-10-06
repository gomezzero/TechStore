using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.Repositories;

namespace TechStore.Controller.V1.Cstomers
{
    [Route("api/v1/customers")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("customers")]
    public class CustomerGetController(ICustomerRepository customerRepository) : CustomerController(customerRepository)
    {

        [HttpGet]
        public async Task<IActionResult> GetAllCustomers()
        {
            var customers = await _customerRepository.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            var customer = await _customerRepository.GetCustomerById(id);

            if (customer == null)
                return NotFound();

            return Ok(customer);
        }
    }
}