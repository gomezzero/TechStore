using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public required string Name { get; set; }

        [Column("description")]
        public required string Description { get; set; }

        [Column("price")]
        public required double Price { get; set; }

        [Column("quantity_in_stock")]
        public required int QuantityInStock { get; set; }

        [Column("caregorye_id")]
        public int CaregoryeId {get; set; }

        // connection with foreign key
        [ForeignKey("caregorie_id")]
        public required  ProductCategorie ProductCategorie { get; set; }

        public Product(string name, string description, double price, int quantityInStock, int caregoryeId)
        {
            Name = name.ToLower().Trim();
            Description = description.ToLower().Trim();
            Price = price;
            QuantityInStock = quantityInStock;
            CaregoryeId = caregoryeId;
        }
    }
}