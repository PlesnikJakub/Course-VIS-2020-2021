using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DomainLayer.DomainModelUnitOfWork
{
    public class UnitOfWork
    {
        private List<Customer> newObjects = new List<Customer>();
        private List<Customer> dirtyObjects = new List<Customer>();
        private List<Customer> removedObjects = new List<Customer>();

        private static ThreadLocal<UnitOfWork> threadLocal = new ThreadLocal<UnitOfWork>();

        public UnitOfWork()
        {
            threadLocal.Value = new UnitOfWork();
        }

        public static UnitOfWork getCurrent()
        {
            if (!threadLocal.IsValueCreated)
                new UnitOfWork();
            return threadLocal.Value;
        }

        public void registerNew(Customer customer)
        {
            newObjects.Add(customer);
        }

        public void registerDirty(Customer customer)
        {
            dirtyObjects.Add(customer);
        }

        public void registerRemove(Customer customer)
        {
            removedObjects.Add(customer);
        }

        public void Commit()
        {
            // insert new
            foreach (Customer customer in newObjects)
            {
                // insert customer to DB
            }

            foreach (Customer customer in dirtyObjects)
            {
                // update customer to DB
            }

            foreach (Customer customer in removedObjects)
            {
                // delete customer to DB
            }
        }

        public void Rollback()
        {
            // clear all ques
        }
    }
}
