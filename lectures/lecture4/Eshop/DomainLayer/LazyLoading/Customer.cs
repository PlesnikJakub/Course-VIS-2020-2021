using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.LazyLoading
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
            // inicialization of lazy loadig
            _addresses = new Lazy<List<Address>>(GetMyAddresses);
        }

        private List<Address> GetMyAddresses()
        {
            // example of fetching data
            // can be fetched from DB, file , etc...
            // try it yourself
            List<Address> a = new List<Address>
            {
                new Address { Country = "USA", Street = "Main" },
                new Address { Country = "USA", Street = "Main2" }
            };

            return a;
        }

        public Customer(int id, string name, bool isPremiumMember)
        {

        }

        public Customer(int id, string name, double salary, int age, string adress)
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
        public void IncreaseSallaryByPercentige(int percentige)
        {
            Salary = Salary * (1 + ((double)percentige / 100));
        }

        public string Print()
        {
            return "Name:" + this.Name + " Age:" + this.Age;
        }
    }
}
