using System.ComponentModel.DataAnnotations;


namespace TechStore.DTOs
{
    public class UserDTO
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public bool Role { get; set; }  // Admin or Employee
    }
}