using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledovanie
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        protected Person() {}

        protected Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
