using Infrastructure.Account;
using System.Data;

namespace Bussiness.Services
{
    public class AccountService
    {
        public List<Account> GetAll()
        {
            var gateway = new AccountDataGateway();
            var result = gateway.GetAll();

            return AccountMapper.Map(result);
        }

        public void AddInterestRate()
        {
            var gateway = new AccountDataGateway();
            var result = gateway.GetAll();
            var accounts = AccountMapper.Map(result);

            foreach (var account in accounts)
            {
                account.AddInterest();
            }
        }
    }
}
