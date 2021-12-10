﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Inheritance
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value >= 15)
                    throw new ArgumentException("Child's age must be less tha 15!");

                base.Age = value;
            }
        }
    }
}
