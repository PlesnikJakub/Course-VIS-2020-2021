using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.DataMapper
{
    // This is incorrectly placed DataMapper
    // Data mapper belongs to DataLayer but it requires to use techniques like dependency injection.
    // DataMapper is powerfull design patter but its hard to implement it right
    public class StudentDataMapper
    {
        public static Student GetStudentByLogin(string login)
        {


            return new Student();
        }

        public static bool Insert(Student student)
        {
            return true;
        }

        public static bool Update(Student student)
        {
            return true;
        }

        public static bool Delete(Student student)
        {
            return true;
        }
    }
}
