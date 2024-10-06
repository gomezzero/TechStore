using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("username")]
        public string Username { get; set; }

        [Column("emails")]
        public string Email { get; set; }

        [Required]
        [Column("password")]
        public string Password { get; set; }

        [Required]
        [Column("role")]
        public bool Role { get; set; }  // "Admin" or "Employee"

        public User(string username, string email, string password, bool role)
        {
            Username = username.ToLower().Trim();
            Email = email.ToLower().Trim();
            Password = password;
            Role = role;
        }
    }
}