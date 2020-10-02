using System;
using System.Collections.Generic;

namespace DomainLayer.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }

        public IEnumerable<OrderItemDTO> Items { get; set; }

        public DateTime CreatedAt { get; private set; }

        public double InvoicedPrice { get; private set; }
    }
}
