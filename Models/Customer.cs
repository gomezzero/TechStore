using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TechStore.Models
{
    [Table("costomers")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("names")]
        public string Name { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("emails")]
        public string Email { get; set; }

        public Customer(string name, string address, string phone, string email)
        {
            Name = name.ToLower().Trim();
            Address = address.ToLower().Trim();
            Phone = phone.Trim();
            Email = email.ToLower().Trim();
        }
    }
}