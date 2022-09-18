using System;
namespace ArrayOfObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Table[] arrayofTable = new Table[10];
            for(int i =0; i<arrayofTable.Length;i++)
            {
                arrayofTable[i] = new Table(rand.Next(50, 201), rand.Next(50, 201));
                arrayofTable[i].ShowData();
            }
        }
    }
}