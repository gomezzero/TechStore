using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.Models
{
   [Table("orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }


        [Column("order_status")]
        public string OrderStatus { get; set; } = "Pending";

        [Column("order_date")]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        // Navigation property to represent the relationship with OrderItem
        public List<OrderItem> OrderItems { get; set; } = new();


        [Column("client_id")]
        public int ClientId { get; set; }


        // connection with foreign key
        [ForeignKey("client_id")]
        public required Customer Customer { get; set; }

        public Order(int clientId)
        {
            ClientId = clientId;
        }
    }
}