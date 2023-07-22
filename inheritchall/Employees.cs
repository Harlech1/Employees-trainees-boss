using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritchall
{
    internal class Employees : Employee
    {
        public int WorkingHours { get; set; }

        public Employees(string role, string firstName, int salary, int workingHours) :base(role, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.Salary = salary;
            this.Role = role;
            this.FirstName = firstName;
        }

        public override void Work()
        {
            //should indicate working hours

            Console.WriteLine($"My name is {FirstName}, my role is {Role}, my salary is {Salary} and my working hours are {WorkingHours}");
        }

        public override void Pause()
        {
            base.Pause();
        }
    }
}
