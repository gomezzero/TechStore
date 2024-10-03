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

        [Required]
        [Column("password_hash")]
        public string PasswordHash { get; set; }

        [Required]
        [Column("role")]
        public bool Role { get; set; }  // "Admin" or "Employee"

        public User(string username, string passwordHash, bool role)
        {
            Username = username.ToLower().Trim();
            PasswordHash = passwordHash;
            Role = role;
        }
        }
}