using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.DTOs;
using TechStore.Repositories;

namespace TechStore.Controller.V1.Users
{
    [Route("api/v1/users")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("users")]
    public class UserUpdateController(IUserRepository userRepository) : UserController(userRepository)
    {
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UserDTO updateUser)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var checkUser = await _userRepository.CheckExistence(id);

            if(checkUser == false)
            {
                return NotFound();
            }

            var user = await _userRepository.GetById(id);

            if(user == null)
            {
                return NotFound();
            }

            user.Username = updateUser.Username;
            user.Role = updateUser.Role;
            user.PasswordHash = updateUser.PasswordHash;

            await _userRepository.Update(user);
            return NoContent();
        }
    }
}