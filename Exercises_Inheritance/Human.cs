using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public class Human
    {
        public string firstName;
        public string lastName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                var firstLetter = value[0];
                if (firstLetter != char.ToUpper(firstLetter))
                    throw new ArgumentException("Expected upper case letter! Argument firstName");

                if (value.Length <= 3)
                    throw new ArgumentException("Expected length at least 4 symbols!");

                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                var firstLetter = value[0];
                if (firstLetter != char.ToUpper(firstLetter))
                    throw new ArgumentException("Expected upper case letter!");

                if (value.Length <= 2)
                    throw new ArgumentException("Expected length at least 3 symbols!");

                lastName = value;
            }
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder human = new StringBuilder();
            human.AppendLine($"First Name: {FirstName}")
                    .AppendLine($"Last Name: {LastName}");

            return human.ToString();
        }
    }
}
