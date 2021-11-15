using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.Account
{
    public class AccountDataGateway
    {
        public DataTable GetAll()
        {
            // Prepare variable for results
            DataTable dataTable = new ();

            // Propare statements
            string sql = "SELECT * FROM ACCOUNTS;";
            
            // Open connection
            using (SqlConnection connection = new SqlConnection(DBConnector.GetConnectionString()))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
                return dataTable;
            }
        }
    }
}
