using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Services
{
    internal class AccountMapper
    {
        public static Account Map(DataRow row)
        {
            return new Account
            {
                Id = Guid.Parse(row["id"].ToString()),
                Name = row["name"].ToString(),
                Balance = (decimal)row["balance"],
                InterestRate = (decimal)row["interest_rate"],
            };
        }

        public static List<Account> Map(DataTable data)
        {
            List<Account> allAcounts = new();
            foreach (DataRow row in data.Rows)
            {
                var account = AccountMapper.Map(row);
                allAcounts.Add(account);
            }

            return allAcounts;
        }
    }
}
