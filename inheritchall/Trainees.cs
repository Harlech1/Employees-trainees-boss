using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritchall
{
    internal class Trainees : Employee
    {

        
        public int SchoolHours { get; set; }

        public Trainees(string role, string firstName, int salary, int schoolHours):base(role, firstName, salary)
        {
       
            this.SchoolHours = schoolHours;
            this.Role = role;
            this.FirstName = firstName;
            this.Salary = salary;
        }

        public void Learn()
        {
            Console.WriteLine("I am a {0} and my name is {1} and im learning",Role,FirstName);
        }

        public override void Work()
        {
            //should indicate working hours

            Console.WriteLine($"My name is {FirstName}, my role is {Role}, my salary is {Salary} and my schools hours are {SchoolHours}");
        }

        public override void Pause()
        {
            base.Pause();
        }
    }
}
