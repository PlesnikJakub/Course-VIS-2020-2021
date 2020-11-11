using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DomanModelActiveRecord
{
    public class CustomerActireRecord
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public int Age { get; set; }

        public string Adrress { get; set; }

        public CustomerActireRecord()
        {

        }

        public CustomerActireRecord( int id, string name, double salary, int age, string adress)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
            this.Age = age;
            this.Adrress = adress;
        }

        public CustomerActireRecord( string name, double salary, int age, string adress)
        {
            this.Name = name;
            this.Salary = salary;
            this.Age = age;
            this.Adrress = adress;
        }

        /* Domain Logic methods*/
        public void IncreaseSallaryByPercentige(int percentige)
        {
            Salary = Salary * (1 + ((double)percentige / 100));
        }

        public string Print()
        {
            return "Name:" + this.Name + " Age:" + this.Age;
        }

        /* Active records queries */
        public static List<CustomerActireRecord> Find()
        {
            string sql = "SELECT * FROM CUSTOMERS;";
            List<CustomerActireRecord> NewCustomersList = new List<CustomerActireRecord>();
            using (SqlConnection connection = new SqlConnection(DBConnector.GetBuilder().ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                { 
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NewCustomersList.Add(MapResultsetToObject(reader));
                        }
                    }
                }
            }
            return NewCustomersList;
        }

        public static CustomerActireRecord Find(int id)
        {
            
            string sql = "SELECT * FROM CUSTOMERS WHERE ID = @id;";
            CustomerActireRecord NewCustomer = null;
            using (SqlConnection connection = new SqlConnection(DBConnector.GetBuilder().ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            NewCustomer = MapResultsetToObject(reader);
                        }
                    }
                }
            }

            return NewCustomer;
        }

        public bool Delete()
        {
            /*TODO*/
            return true;
        }

        public CustomerActireRecord Update()
        {
            /*TODO*/
            return null;
        }

        public CustomerActireRecord Insert()
        {
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Clear();
                sb.Append("INSERT INTO CUSTOMERS (NAME,AGE,ADDRESS,SALARY)");
                sb.Append("VALUES (@name, @age, @adress, @salary);");
                sb.Append("SELECT CAST(scope_identity() AS int)");
                string sql = sb.ToString();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", Name);
                    command.Parameters.AddWithValue("@age", Age);
                    command.Parameters.AddWithValue("@adress", Adrress);
                    command.Parameters.AddWithValue("@salary", Salary);
                    int modified = (int)command.ExecuteScalar();
                    this.Id = modified;
                }
            }
            return this;
        }

        /* Helper method to map result to object */
        private static CustomerActireRecord MapResultsetToObject(SqlDataReader reader)
        {
            CustomerActireRecord NewCustomer = new CustomerActireRecord();
            NewCustomer.Id = reader.GetInt32(0);
            NewCustomer.Name = reader.GetString(1);
            NewCustomer.Salary = (double)reader.GetDecimal(4);
            NewCustomer.Age = reader.GetInt32(2);
            NewCustomer.Adrress = reader.GetString(3);

            return NewCustomer;
        }
    }
}
