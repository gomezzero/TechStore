using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.DTOs
{
    public class UserDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public bool Role { get; set; }  // Admin or Employee
    }
}