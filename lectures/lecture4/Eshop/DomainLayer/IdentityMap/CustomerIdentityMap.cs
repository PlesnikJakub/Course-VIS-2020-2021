using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.IdentityMap
{
    public class CustomerIdentityMap : IMap<Customer>
    {
        private Dictionary<int, Customer> map = new Dictionary<int, Customer>();

        Dictionary<int, Customer> IMap<Customer>.map { get; set; }

        public Customer Get(int id)
        {
            if (map.ContainsKey(id))
            {
                return map[id];
            }

            return null;
        }

        public void Add(Customer customer)
        {
            map.Add(customer.Id, customer);
        }
    }
}
