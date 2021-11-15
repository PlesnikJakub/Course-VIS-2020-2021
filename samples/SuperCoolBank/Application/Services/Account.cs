namespace Bussiness.Services
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; } = 1;

        public decimal AddInterest()
        {
            var interest = (Balance / (decimal)100) * InterestRate;
            Balance += interest;

            return Balance;
        }
    }
}
