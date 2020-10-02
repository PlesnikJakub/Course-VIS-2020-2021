using DataLayer;
using DomainLayer.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.TableModule
{
    /// <summary>
    /// A single instance that handles the business logic for all rows in a database table or view.
    /// https://martinfowler.com/eaaCatalog/tableModule.html
    /// </summary>
    public class OrderModule
    {
        public void SubmitOrder(int userId, IEnumerable<OrderItemDTO> items)
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

        public void CancelOrder(int userId, int orderId)
        {
            // MOCK
        }
    }
}
