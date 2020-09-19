using Infrastructure.Repositories;

namespace Application.Services
{
    public class AccountService
    {
        public int GetAccountBalance(int accountId)
        {
            var repository = new AccountRepository();
            var account = repository.GetAccount(accountId);

            return account.Balance;
        }
    }
}
