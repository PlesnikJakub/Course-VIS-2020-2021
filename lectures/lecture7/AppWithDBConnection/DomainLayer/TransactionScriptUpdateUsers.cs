using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.DomainModelUnitOfWork;

namespace DomainLayer
{
    public class TransactionScriptUpdateUsers
    {
        public void UpdateCustomersFromFeed()
        {
            UnitOfWork uw = new UnitOfWork();
            // get customers 

            // new obj - not in DB
            Customer a = new Customer();

            // old instance already in DB
            Customer b = new Customer();
            b.UpdateName("aaaa");

            // critical part 
            try
            {

            }
            catch
            {
                uw.Rollback();
                return;
            }

            uw.Commit();
        }
    }
}
