using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Repositories;

namespace TechStore.Controller.V1.Cstomers
{
    [Route("api/v1/customers")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("customers")]
    public class CustomerCreateController(ICustomerRepository customerRepository) : CustomerController(customerRepository)
    {

        [HttpPost]
        public async Task<IActionResult> AddCustomer(ClientDTO newCustomer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _customerRepository.AddCustomer(newCustomer);

            return Ok("Customer added successfully.");
        }
    }

}
