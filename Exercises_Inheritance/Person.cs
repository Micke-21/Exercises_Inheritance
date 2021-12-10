using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public class Person
    {
        private int age;

        public string Name { get; set; }
        public virtual int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be possitive!");
                }
                else
                {
                    age = value;
                }
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                this.Name,
                this.Age));

            return stringBuilder.ToString();
        }
    }
}
