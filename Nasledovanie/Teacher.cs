﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledovanie
{
    public class Teacher : Worker, IFaculty, IToString
    {
        public string Faculty { get; set; }
        public Teacher() { }
        public Teacher(string name, int age, double salary, string faculty) : base(name, age, salary)
        {
            Faculty = faculty;
        }

        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\tFaculty: {Faculty}";
        }
    }
}
