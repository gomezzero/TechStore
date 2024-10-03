using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

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
        public required string Name { get; set; }

        [Column("address")]
        public required string Address { get; set; }

        [Column("phone")]
        public required string Phone { get; set; }

        [Column("emails")]
        public required string Email { get; set; }

        public Customer(string name, string address, string phone, string emails)
        {
            Name = name.ToLower().Trim();
            Address = address.ToLower().Trim();
            Phone = phone.Trim();
            Email = emails.ToLower().Trim();
        }
    }
}