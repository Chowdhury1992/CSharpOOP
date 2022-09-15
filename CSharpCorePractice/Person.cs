using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCorePractice
{
    public class Person
    {
        string _name;
        int _age;
        public string Name { set; get; }
        public int Age { set; get; }
        public Person(string name)
        {
            Name = name;
        }
        public Person()
        {
            Name =string.Empty;
        }
        public string Greet()
        {
            return "Hello!";
        }
        public void setAge(int age)
        {
            Age = age;
        }
        public override string ToString()
        {
            return $"Hello! My name is {Name}";
        }
    }
}
