using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Models;
using TechStore.Repositories;
using TechStore.Utils;

namespace TechStore.Controller.V1.Users
{
    [Route("api/v1/users")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("users")]
    public class UserCreateController(IUserRepository userRepository) : UserController(userRepository)
    {
        [HttpPost]
        [Authorize] // etiqueta para permitir bloquear el uso de enpins con JWT
        public async Task<ActionResult<User>> Create(UserDTO inputUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Hashear la contraseña antes de guardar
            var hashedPassword = PasswordHasher.HashPassword(inputUser.Password);

            var newUser = new User(inputUser.Username, inputUser.Email, hashedPassword, inputUser.Role);

            await _userRepository.Add(newUser);

            return Ok(newUser);
        }
    }
}