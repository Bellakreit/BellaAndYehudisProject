///Class for an employee
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //intitalize employees and their salary 
    internal class Employee
    : Person
    {
        public double Salary { get; set; } //Property to store salary
        /// <summary>
        /// a ctor for an employees objects
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="salary"></param>
        public Employee(string name, string id, double salary)
            : base(name, id)
        {
            Salary = salary;
        }

    }

}
