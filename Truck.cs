using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double BedSize { get; set; } = 12.2;
        public int HowManyDoors { get; set; } = 2;
        public int Tires { get; set; } = 5;
        public bool Gasoline { get; set; } = true;
        public bool Trunk { get; set; } = true;
        public bool IsFourDoors { get; set; } = false;
        public bool Logo { get; set; } = true;
        public bool Employees { get; set; } = true;
        public bool HasChangedGear { get; set; } = true;
        public bool ChangeGear { get ; set ; }

        public void Drive()
        {
            if (HasChangedGear == true)
            {
                Console.WriteLine($"{GetType().Name} changed gear...");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward...");
            }
        }

        public void Reverse()
        {
            if (Gasoline == true)
            {
                Console.WriteLine($"{GetType().Name} uses Gasoline instead of diesel");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} Make sure to uses Diesel...");
            }
            

        }

    

    }
}
