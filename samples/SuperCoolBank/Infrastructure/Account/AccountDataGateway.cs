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

        public DataTable GetById(Guid id)
        {
            // Prepare variable for results
            DataTable dataTable = new();

            // Propare statements
            string sql = "SELECT * FROM ACCOUNTS WHERE [ID] = @ID;";

            // Open connection
            using (SqlConnection connection = new SqlConnection(DBConnector.GetConnectionString()))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ID", id.ToString());
                using SqlDataReader reader = command.ExecuteReader();

                dataTable.Load(reader);
                return dataTable;
            }
        }

        public bool Update(Guid id, decimal balance)
        {
            // Propare statements
            string sql = "UPDATE ACCOUNTS SET BALANCE = @BALANCE WHERE [ID] = @ID;";

            // Open connection
            using (SqlConnection connection = new SqlConnection(DBConnector.GetConnectionString()))
            {
                connection.Open();
                using SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ID", id.ToString());
                command.Parameters.AddWithValue("@BALANCE", balance);

                var rowsAffected = command.ExecuteNonQuery();
                return rowsAffected == 1;
            }
        }
    }
}
