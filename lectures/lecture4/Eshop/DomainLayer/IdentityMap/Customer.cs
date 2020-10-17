namespace DomainLayer.IdentityMap
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public int Age { get; set; }

        public string Adrress { get; set; }

        public Customer()
        {

            this.Id = -1;
            this.Name = "Pepa";
        }

        public void UpdateName(string Name)
        {
            this.Name = Name;
        }

        public Customer(int id, string name, bool isPremiumMember)
        {

        }

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