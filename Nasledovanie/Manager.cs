using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledovanie
{
    public class Manager : Worker, IToString
    {
        public string Position { get; set; }

        public Manager() { }

        public Manager(string name, int age, double salary, string position) : base(name, age, salary)
        {
            Position = position;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\tPosition: {Position}";
        }
    }
}
