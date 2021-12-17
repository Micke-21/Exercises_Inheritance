using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public class Worker : Human
    {
        //public string FirstName { get; }
        //public string LastName { get; }
        public decimal WeekSalary { get; }
        public decimal WorkHoursPerDay { get; }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            if (weekSalary <= 10)
                throw new ArgumentException("Expected value mismatch!");
            WeekSalary = weekSalary;

            if (workHoursPerDay < 2 || workHoursPerDay > 12)
                throw new ArgumentException("Expected value mismatch!");

            WorkHoursPerDay = workHoursPerDay;
        }

        public override string ToString()
        {
            StringBuilder worker = new StringBuilder();
            worker.Append(base.ToString())
                .AppendLine($"Week Salary: {WeekSalary}")
                .AppendLine($"Hours per day: {WorkHoursPerDay}")
                .AppendLine($"Salary per hour: {WeekSalary / 5 / WorkHoursPerDay:f2} ");

            return worker.ToString();
        }
    }
}
