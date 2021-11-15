using Infrastructure.Account;
using System.Data;

namespace Bussiness.Services
{
    public class AccountService
    {
        private readonly AccountDataGateway accountDataGateway;
        public AccountService()
        {
            accountDataGateway = new ();
        }

        public List<Account> GetAll()
        {
            var result = accountDataGateway.GetAll();
            return AccountMapper.Map(result);
        }

        public void AddInterestRate()
        {
            var result = accountDataGateway.GetAll();
            var accounts = AccountMapper.Map(result);

            foreach (var account in accounts)
            {
                account.AddInterest();
                var updated = accountDataGateway.Update(account.Id, account.Balance);
            }
        }
    }
}
