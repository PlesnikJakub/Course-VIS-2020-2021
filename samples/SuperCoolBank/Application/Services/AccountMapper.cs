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
        public static List<Account> Map(DataTable data)
        {
            var allAcounts = new List<Account>();
            foreach (DataRow row in data.Rows)
            {
                var account = Map(row);
                allAcounts.Add(account);
            }

            return allAcounts;
        }

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
    }
}
