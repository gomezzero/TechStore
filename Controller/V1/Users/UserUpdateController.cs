using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechStore.DTOs;
using TechStore.Repositories;
using TechStore.Utils; // Asegúrate de importar la clase PasswordHasher desde Utils

namespace TechStore.Controller.V1.Users
{
    [Route("api/v1/users")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("users")]
    public class UserUpdateController(IUserRepository userRepository) : UserController(userRepository)
    {
        [HttpPut("{id}")]
        [Authorize] // etiqueta para permitir bloquear el uso de endpoints con JWT
        public async Task<IActionResult> Update(int id, UserDTO updateUser)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var checkUser = await _userRepository.CheckExistence(id);

            if(!checkUser)
            {
                return NotFound();
            }

            var user = await _userRepository.GetById(id);

            if(user == null)
            {
                return NotFound();
            }

            // Actualizamos los campos del usuario
            user.Username = updateUser.Username;
            user.Email = updateUser.Email;
            user.Role = updateUser.Role;

            // Si se proporciona una nueva contraseña, la hasheamos
            if (!string.IsNullOrWhiteSpace(updateUser.Password))
            {
                user.Password = PasswordHasher.HashPassword(updateUser.Password);
            }

            await _userRepository.Update(user);
            return NoContent();
        }
    }
}