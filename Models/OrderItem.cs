using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Models
{
    [Table("order_items")]
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }


        [Column("quantity")]
        public int Quantity { get; set; }

        
        [Column("order_id")]
        public int OrderId { get; set; }


        [Column("product_id")]
        public int ProductId { get; set; }


        // connection with foreign key
        [ForeignKey("order_id")]
        public required Order Order { get; set; }

        [ForeignKey("product_id")]
        public required Product Product { get; set; }


        public OrderItem(int quantity, int productId, int orderId)
        {
            Quantity = quantity;
            ProductId = productId;
            OrderId = orderId;
        }
    }
}