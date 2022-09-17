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
            Person[] people = new Person[3];
            Person person = new Person();
            for(int i=0; i<people.Length; i++)
            {
                if(i==0)
                {
                    Console.WriteLine("Please enter the teacher name.");
                    people[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Please enter the Student name.");
                    people[i] = new Student(Console.ReadLine());
                }
            }
            for (int i = 0; i < people.Length; i++)
            {
                if (i ==0)
                {
                    ((Teacher)people[i]).Explain();

                }
                else
                {
                    ((Student)people[i]).Study();
                }
            }
               

            //PhotoBook class
            PhotoBook photoBook = new PhotoBook();
            PhotoBook photoBook1 = new PhotoBook(24);
            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(photoBook.GetNumberPages());
            Console.WriteLine(photoBook1.GetNumberPages());
            Console.WriteLine(bigPhotoBook.GetNumberPages());


    }
    }
}