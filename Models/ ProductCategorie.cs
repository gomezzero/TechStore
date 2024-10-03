using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechStore.Models
{
    [Table("product_categories")]
    public class ProductCategorie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }


        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        public ProductCategorie(string name, string? description = null)
        {
            Name = name.ToLower().Trim();
            Description = description?.ToLower().Trim();
        }
    }
}