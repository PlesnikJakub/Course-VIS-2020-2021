namespace DomainLayer.DomainModelUnitOfWork
{
    public class Customer : IUnitOfWorkCompatible
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
            MarkNew();
        }

        public void UpdateName(string Name)
        {
            this.Name = Name;
            MarkDirty();
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

        public void MarkNew()
        {
            UnitOfWork.getCurrent().registerNew(this);
        }

        public void MarkDirty()
        {
            UnitOfWork.getCurrent().registerDirty(this);
        }

        public void MarkRemoved()
        {
            UnitOfWork.getCurrent().registerRemove(this);
        }
    }