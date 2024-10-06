using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechStore.DTOs
{
    public class OrderDTO
    {
        [Required]
        public int ClientId { get; set; }

        public string ClientName { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public string OrderStatus { get; set; }

        public List<OrderItemDTO> OrderItems { get; set; }
    }
}