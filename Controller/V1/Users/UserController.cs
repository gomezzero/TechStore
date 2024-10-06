using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.Repositories;

namespace TechStore.Controller.V1.Users
{
    [Route("api/V1[controller]")]
    public class UserController(IUserRepository userRepository) : ControllerBase
    {
        protected readonly IUserRepository _userRepository = userRepository;
    }
}