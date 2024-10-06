using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Models;
using TechStore.Repositories;

namespace TechStore.Controller.V1.Users
{
    [Route("api/v1/users")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("users")]
    public class UserCreateController(IUserRepository userRepository) : UserController(userRepository)
    {
        [HttpPost]
        public async Task<ActionResult<User>> Create(UserDTO inputUser)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newUser = new User(inputUser.Username, inputUser.Email, inputUser.Password, inputUser.Role);

            await _userRepository.Add(newUser);

            return Ok(newUser);
        }
    }
}