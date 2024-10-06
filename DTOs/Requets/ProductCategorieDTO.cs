using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.DTOs
{
    public class ProductCategorieDTO
    {
        [Required]
        public string Name { get; set; }

        public string? Description { get; set; }
    }
}