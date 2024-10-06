using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Repositories;

namespace TechStore.Controller.V1.Cstomers
{
    [Route("api/v1/customers")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("customers")]
    public class CustomerUpdateController(ICustomerRepository customerRepository) : CustomerController(customerRepository)
    {

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(int id, ClientDTO updateCustomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customer = await customerRepository.GetCustomerById(id);

            if (customer == null)
                return NotFound();

            await customerRepository.UpdateCustomer(id, updateCustomer);

            return NoContent();
        }
    }
}