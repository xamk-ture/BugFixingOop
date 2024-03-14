using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugFixingOop.Models
{
    // Problem Description:
    // The Employee class does not inherit any properties or methods from the Person class.
    // Task: Modify the Employee class so that it inherits from the Person class.
    // NOTE!: Uncomment test Employee_InheritsFromPerson when you are ready to test
    public class Employee
    {
        public string EmployeeID { get; set; } // Employee should inherit from Person
    }
}
