using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingOop.Models
{
    // Problem Description:
    // The Person class exposes its fields publicly, which violates the principle of encapsulation.
    // Task: Refactor the class to properly encapsulate its fields, using properties.

    // Problem Description:
    // The Age property allows for negative values, which is not valid.
    // Task: Modify the Age property setter to prevent negative values from being assigned.
    public class Person
    {
        public string name;
        public int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
