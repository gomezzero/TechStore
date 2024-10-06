using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.DTOs;
using TechStore.Models;
using TechStore.Repositories;

namespace TechStore.Controller.V1.Users
{
    [Route("api/v1/users")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("users")]
    public class UserDeleteController(IUserRepository userRepository) : UserController(userRepository)
    {
        [HttpDelete("{id}")]
        [Authorize] // etiqueta para permitir bloquear el uso de enpins con JWT

        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userRepository.CheckExistence(id);

            if (user == false)
            {
                return NotFound();
            }

            await _userRepository.Delete(id);

            return NotFound();
        }
    }
}