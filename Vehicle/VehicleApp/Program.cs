namespace VehicleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            car.Drive();
            car.Refuel(50);
            car.Drive();
        }
    }
}