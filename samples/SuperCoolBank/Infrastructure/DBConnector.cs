using System.Data.SqlClient;

namespace Infrastructure
{
    /// <summary>
    /// Helper class for creating an connection string.
    /// </summary>
    internal class DBConnector
    {
        public static string GetConnectionString()
        {
            return @"Data Source=A101-PLESNIK\SQLEXPRESS;Initial Catalog=bank;Integrated Security=True";
        }
    }
}
