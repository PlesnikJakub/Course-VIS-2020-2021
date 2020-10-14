using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataLayer.TableDataGateway
{
    public class StudentTDG
    {
        // You can use DTO or pass data in some other way
        public StudentDTO GetStudentByLogin(string login)
        {
            // Call to DB HERE
            return new StudentDTO();
        }

        // For example you can use design pattern record set that is implemented by DataTable
        // Mapping from data to DTO may be hard sometimes
        public DataTable GetStudentByLogin2(string login)
        {
            var dataTable = new DataTable();
            List<Dictionary<string, object>> Customers = new List<Dictionary<string, object>>();
            string sql = "SELECT * FROM STUDENTS;";
            SqlConnectionStringBuilder builder = DBConnector.GetBuilder();
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }

        public IEnumerable<StudentDTO> GetAllStudents()
        {
            // Call to DB HERE

            return new List<StudentDTO>();
        }

        // Same as above you need to pass DTO or 
        public bool Insert(StudentDTO student)
        {
            // Call to DB HERE

            return true;
        }

        // primitive parametters
        public bool Insert(string name, string login)
        {
            // Call to DB HERE

            return true;
        }
    }
}
