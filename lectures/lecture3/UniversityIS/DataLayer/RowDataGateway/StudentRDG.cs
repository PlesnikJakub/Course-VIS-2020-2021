using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.RowDataGateway
{
    public class StudentRDG
    {
        public string Name { get; set; }

        public string Login { get; set; }

        public bool Update()
        {
            // Call to DB HERE

            return true;
        }

        public bool Insert()
        {
            // Call to DB HERE

            return true;
        }
    }
}
