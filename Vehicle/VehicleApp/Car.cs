using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    public class Car : IVehicle
    {
        int _amountOfGasoline;
        public int AmountOfGasoline { get; set; }
        public Car(int gasoline)
        {
            AmountOfGasoline = gasoline;
        }
        public void Drive()
        {
            if (AmountOfGasoline > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("There is not enough gasoline to start the car");
            }
        }

        public bool Refuel(int amountOfGasoline)
        {
            AmountOfGasoline += amountOfGasoline;
            if(AmountOfGasoline > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
