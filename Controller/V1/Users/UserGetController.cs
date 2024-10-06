using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.Models;
using TechStore.Repositories;

namespace TechStore.Controller.V1.Users
{
    [Route("api/v1/users")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("users")]
    public class UserGetteController(IUserRepository userRepository) : UserController(userRepository)
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            var user = await _userRepository.GetAll();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(int id)
        {
            var user = await _userRepository.GetById(id);

            if(user == null)
            {
                return NotFound();
            }
            return user;
        }

        [HttpGet("serach/{keyword}")]
        public async Task<ActionResult<IEnumerable<User>>> SearchByKeyword(string keyword)
        {
            if(string.IsNullOrWhiteSpace(keyword))
            {
                return BadRequest("La palabra clave no puede estar vasia");
            }

            var user = await _userRepository.GetByKeyword(keyword);

            if(!user.Any())
            {
                return NotFound("no se encontraron usuarios con concidencias");
            }

            return Ok(user);
        }
    }
}