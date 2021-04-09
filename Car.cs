using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car :IVehicle, ICompany
    {
        public int TireSize { get; set; } = 13;
        public int HowManySeats { get; set; } = 7;
        public bool Logo { get; set; } = true;
        public bool Employees { get; set; } = true;
        public int Tires { get; set; } = 5;
        public bool Gasoline { get; set; } = true;
        public bool Trunk { get; set; } = true;
        public bool IsFourDoors { get; set; } = true;
        public bool ChangeGear { get; set; }



        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward...");
        }
        public void Reverse()
        {
            if (ChangeGear == true)
            {
                Console.WriteLine($"{GetType().Name} now is reversing...");
                ChangeGear = false;
            }
            else
            {
                Console.WriteLine($"Cant Reverse untill we change gears");
            }
            //Console.WriteLine($"{GetType().Name} now driving reverse...");
        }
        
    }
}
