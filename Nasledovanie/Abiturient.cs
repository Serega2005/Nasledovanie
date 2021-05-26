using System;
using System.Collections.Generic;
using System.Text;

namespace Nasledovanie
{
    public class Abiturient : Person, IFaculty
    {
        public string Faculty { get; set; }
    }
}
