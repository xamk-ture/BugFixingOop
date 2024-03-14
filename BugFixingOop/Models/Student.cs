using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingOop.Models
{

    // Problem Description:
    // The ToString method in the Student class is meant to override the method in the base class but uses 'new' instead of 'override'.
    // Task: Fix the ToString method in the Student class to correctly override the base class method.

    // Problem Description:
    // The Student class constructor does not call the base class constructor, leading to uninitialized properties.
    // Task: Fix the Student constructor to correctly initialize the base class Person.
    public class Student : Person
    {
        public string StudentID { get; set; }
        public new string ToString()
        {
            return $"Name: {Name}, ID: {StudentID}";
        }

        public Student(string studentID) : base("")
        {
            StudentID = studentID;
        }
    }
}
