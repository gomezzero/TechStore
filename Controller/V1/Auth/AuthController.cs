using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.Repositories;

namespace TechStore.Controller.V1.Auth
{
    [Route("api/v1/auth")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class AuthController : ControllerBase
    {
        protected readonly IUserRepository servicios;

        public AuthController(IUserRepository userRepository)
        {
            servicios = userRepository;
        }

        
    }
}