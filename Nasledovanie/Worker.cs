using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledovanie
{
    public class Worker : Person
    {
        public double Salary { get; set; }

        protected Worker(string name, int age, double salary) :  base(name, age)
        {
            Salary = salary;
        }
    }
}
