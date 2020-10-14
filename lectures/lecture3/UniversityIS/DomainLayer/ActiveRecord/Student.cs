using System.Collections.Generic;

namespace DomainLayer.ActiveRecord
{
    /// <summary>
    /// Yes this class belongs to DomainLayer. This doesnt mean that there must be SQL written directly.
    /// </summary>
    public class Student
    {
        // Data
        public string Name { get; set; }

        public string Login { get; set; }

        private IEnumerable<double> Grades = new List<double>(); 

        // Behavior
        public double ComputeFinalGrade()
        {
            // TODO
            // Compute grade for student
            return 0.0;
        }

        public bool HasRightsToScholarship()
        {
            // TODO
            // Compute if student has rights to access scholarship.
            return true;
        }

        // Data Access
        public static Student GetStudentByLogin(string login)
        {
            // Call to DB HERE
            // Option 1. Directly call SQL
            // Option 2. Call some class from DataLayer project(TDG)

            return new Student();
        }

    }
}
