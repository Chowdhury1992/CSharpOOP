using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCorePractice
{
    public class Teacher:Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}
