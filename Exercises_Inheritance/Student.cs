using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public class Student : Human
    {
        public string FacultyNumber { get; }

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            if (facultyNumber.Length < 5 || facultyNumber.Length > 10)
                throw new ArgumentException("Invalid faculty number");

            FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            var student = new StringBuilder();
            student
                .Append(base.ToString())
                //.AppendLine($"First Name: {FirstName})")
                //.AppendLine($"Last Name: {LastName}")
                .AppendLine($"Faculty number: {FacultyNumber}");

            return student.ToString();
        }

    }
}
