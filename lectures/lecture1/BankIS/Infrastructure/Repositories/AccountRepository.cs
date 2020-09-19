using Infrastructure.Models;

namespace Infrastructure.Repositories
{
    public class AccountRepository
    {
        public Account GetAccount(int accountId)
        {
            // Some call to SQL instead of this would be better :) 
            return new Account
            {
                AccountId = accountId,
                Balance = 15000,
                Holder = "Joe A."
            };
        }
    }
}
