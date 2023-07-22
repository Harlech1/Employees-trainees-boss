using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritchall
{
    internal class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string role, string firstName, int salary, string companyCar):base(role, firstName,salary)
        {
            this.Role = role;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;       
        }

        public void Lead()
        {
            Console.WriteLine("I am leading, my role is {0}," +
                " my name is {1}" +
                ", and i have a car named {2}," +
                " and my salary is {3}", Role, FirstName, CompanyCar, Salary);
        }

        public override void Work()
        {
            base.Work();
        }

        public override void Pause()
        {
            base.Pause();
        }
    }
}
