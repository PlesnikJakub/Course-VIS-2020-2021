using DataLayer;
using DomainLayer.DTO;
using System;
using System.Collections.Generic;

namespace DomainLayer.TransactionScript
{
    /// <summary>
    /// Organizes business logic by procedures where each procedure handles a single request from the presentation.
    /// https://martinfowler.com/eaaCatalog/transactionScript.html
    /// </summary>
    public class SubmitOrder
    {
        // Logic
        public void Execute(int userId, IEnumerable<OrderItemDTO> items)
        {
            var userDataAccess = new UserDA();

            double price = 0;
            foreach (var item in items)
            {
                price += item.Price;
            }

            var discountRate = userDataAccess.GetDiscountForUser(userId);
            var totalPrice = 0.0;
            if (discountRate > 0)
            {
                totalPrice = totalPrice * discountRate;
            }

            var orderDataAccess = new OrderDA();

            orderDataAccess.SubmitOrder(userId, DateTime.Now, totalPrice);
        }
    }
}
