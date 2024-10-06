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
    [Route("api/V1[controller]")]
    public class CustomerController(ICustomerRepository customerRepository) : ControllerBase
    {
        protected readonly ICustomerRepository _customerRepository = customerRepository;
    }
}