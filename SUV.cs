using System;
namespace InterfaceExercise
{
    public class SUV : ICompany,IVehicle
    {
        public int CargoSize { get; set; }
        public bool ExtraTire { get; set; }
        public bool Logo { get; set; }
        public bool Employees { get; set; }
        public string Tires { get; set; }
        public bool Gasoline { get; set; }
        public bool Trunk { get; set; }
        public bool IsFourDoors { get; set; }
        public bool ChangeGear { get ; set ; }

        public void Drive()
        {
            if (CargoSize > 10)
            {
                Console.WriteLine($"Your {GetType().Name} 's bed is too small");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} needs a bigger bed");
            }
        }
        public void Reverse()
        {
            Console.WriteLine($"{GetType().Name} now driving reverse...");
        }

    }
}
