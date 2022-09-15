using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace CSharpCorePractice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP");
            List<Person> persons = new List<Person>()
            {
               new Person("Juan"),
               new Person("Sara"),
               new Person("Carlos"),
               
            };
           
            foreach (var obj in persons)
            {
                Console.WriteLine(obj.ToString());
            }
            Person person = new Person();
            Student student = new Student();
            Professor professor = new Professor();
            Console.WriteLine(person.Greet());
            Console.WriteLine(student.Greet());
            student.setAge(21);
            student.ShowAge();
            student.Study();
            Console.WriteLine(professor.Greet());
            professor.Explain();



    }
    }
}