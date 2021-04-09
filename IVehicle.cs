using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {

        //public string Tires { get; set; }
        public bool Gasoline { get; set; }
        public bool Trunk { get; set; }
        public bool IsFourDoors { get; set; }
        public bool ChangeGear { get; set; }
        public void Drive();
        public void Reverse();
        //void ChangeGear(bool v);
    }
}
