using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DomainModel
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public int Age { get; set; }

        public string Adrress { get; set; }

        private Lazy<List<Address>> _addresses;

        public List<Address> Addresses
        {
            get
            {
                return _addresses.Value;
            }
        }

        public Customer()
        {
            _addresses = new Lazy<List<Address>>(() => GetMyAddresses());
        }

        private List<Address> GetMyAddresses()
        {
            // example of fetching data
            // can be fetched from DB, file , etc...

            List<Address> a = new List<Address>();

            a.Add(new Address { Country = "USA", Street = "Main" });
            a.Add(new Address { Country = "USA", Street = "Main2" });

            return a;
        }

        public Customer(int id, string name, bool isPremiumMember)
        {

        }

        public Customer( int id, string name, double salary, int age, string adress)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Age = age;
            this.Adrress = adress;
        }

        public Customer(string name, double salary, int age, string adress)
        {
            this.Name = name;
            this.Salary = salary;
            this.Age = age;
            this.Adrress = adress;
        }


        /* Some Logic*/

        public void IncreaseSallaryByPercentige( int percentige)
        {
            Salary = Salary * (1 + ((double)percentige/100));
        }

        public string Print()
        {
            return "Name:" + this.Name + " Age:" + this.Age;
        }

        public static Customer GetByID(int id)
        {
            // TODO 
            return new Customer();
        }

        public Payment CalculatePayment(int month)
        {
            /// get worksheet for given month
            Worksheet worksheet = new Worksheet();

            Payment p = new Payment();
            p.Amount = worksheet.Hours < 150 ? (worksheet.Hours * Salary) * 0.75 : (worksheet.Hours * Salary) * 0.85;
            p.Date = DateTime.UtcNow;
            // SAVE IT
            return p;
        }
    }
}
