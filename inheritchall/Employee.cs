using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritchall
{
    internal class Employee
    {
        public string Role { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string role, string firstName, int salary) {
            
            this.Role = role;
            this.FirstName = firstName;
            this.Salary = salary;
        }  

        public virtual void Work()
        {
            Console.WriteLine($"My name is {FirstName}, my role is {Role}, my salary is {Salary}");
        }

        public virtual void Pause()
        {
            Console.WriteLine($"My name is {FirstName}, my role is {Role} and i have paused");
        }
    }
}
