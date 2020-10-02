using DomainLayer.DTO;
using System;
using System.Collections.Generic;

namespace DomainLayer.DomainModel
{
    /// <summary>
    /// An object model of the domain that incorporates both behavior and data.
    /// https://martinfowler.com/eaaCatalog/domainModel.html
    /// </summary>
    public class Order
    {
        // Data
        public int Id { get; set; }

        public User Customer { get; set; }

        public IEnumerable<OrderItemDTO> Items { get; set; }

        public DateTime CreatedAt { get; private set; }

        public double InvoicedPrice { get; private set; }


        public Order(int userId, IEnumerable<OrderItemDTO> items)
        {
            Customer = User.GetCustomeById(userId);
            CreatedAt = DateTime.Now;
            Items = items;
        }

        // Logic
        public void SubmitOrder()
        {
            double totalPrice = 0;
            foreach (var item in Items)
            {
                totalPrice += item.Price;
            }

            if (Customer.DiscountRate > 0)
            {
                totalPrice *= Customer.DiscountRate;
            }

            InvoicedPrice = totalPrice;
        }

        public void CancelOrder()
        {
            // MOCK
        }
    }
}
