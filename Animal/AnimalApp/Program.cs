namespace AnimalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Tobby = new Dog();
            Tobby.SetName("Tobby");
            Console.WriteLine(Tobby.GetName());
            Tobby.Eat();
        }
    }
}