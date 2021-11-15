using System.Data.SqlClient;

namespace Infrastructure
{
    /// <summary>
    /// Helper class for creating an connection string.
    /// </summary>
    internal class DBConnector
    {
        public static SqlConnectionStringBuilder GetBuilder()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"localhost";   // update me
            builder.UserID = "ple0049";              // update me
            builder.Password = "*******";      // update me
            builder.InitialCatalog = "ple0049";
            return builder;
        }

        public static string GetConnectionString()
        {
            return @"Data Source=A101-PLESNIK\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True";
        }
    }
}
