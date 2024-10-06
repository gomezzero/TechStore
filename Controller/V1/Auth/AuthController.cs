using Microsoft.AspNetCore.Mvc;
using TechStore.Config;
using TechStore.DTOs.Requets;
using TechStore.Models;
using TechStore.Repositories;
using TechStore.Utils;

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

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginDTO data)
        {
            var user = await servicios.GetByEmail(data.Email);

            if (user == null)
            {
                return BadRequest("El usuario no existe");
            }

            // Verificar la contraseña hasheada
            bool isPasswordValid = PasswordHasher.VerifyPassword(data.Password, user.Password);

            if (!isPasswordValid)
            {
                return BadRequest("Contraseña incorrecta");
            }

            if (user.Role != true)
            {
                return Unauthorized($"Suerte, no tiene los permisos necesarios");
            }

            var token = JWT.GenerateJwtToken(user);

            return Ok($"ACA ESTA SU TOKEN: {token}");
        }

    }
}