using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.DTOs
{
    public class OrderItemDTO
    {

        [Required]
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public string OrderId { get; set; }
    }
}