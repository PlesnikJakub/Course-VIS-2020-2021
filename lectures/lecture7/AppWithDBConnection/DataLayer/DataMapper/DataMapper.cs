using DomainLayer.DomainModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataMapper
{
    public class DataMapper<T>
    {
        public const string CONNECTION_STRING = "";
        public List<T> Find()
        {
            return null;
        }

        public static Customer GetByID(int id)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT TOP 1 * FROM [Customer] WHERE [ID] = @ID";
                    command.Parameters.AddWithValue("@ID", id);

                    SqlDataReader reader = command.ExecuteReader();
                    // If the query returned a row, create the Customer object and return it.
                    if (reader.HasRows)
                    {
                        reader.Read();
                        string name = (string)reader["Name"];
                        bool isPremiumMember = (bool)reader["IsPremiumMember"];

                        return new Customer(id, name, isPremiumMember);
                    }
                }
            }

            return null;
        }

        // Notice that we need to pass in the Customer object (or some information from it)
        // to use some of the methods in the DataMapper class.

        public void Save(Customer customer)
        {
            // This method needs to handle INSERT (new Customer) and UPDATE (existing Customer).
            // Or, you would need to create two separate functions, and call them when appropriate.

            // Pretend there is code here to do the insert and/or update to the database.
        }

        public void Delete(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.Text;

                    command.CommandText = "DELETE FROM [Customer] WHERE [ID] = @ID";
                    command.Parameters.AddWithValue("@ID", customer.Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}