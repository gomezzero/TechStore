using System.ComponentModel.DataAnnotations;

namespace TechStore.DTOs
{
    public class ProductCategorieDTO
    {
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}