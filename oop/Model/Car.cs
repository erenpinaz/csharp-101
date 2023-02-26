using OOP.Enum;

namespace OOP.Model
{
    sealed class Car : Vehicle
    {
        public int MaxSpeed { get; set; }

        public Car(string make, string model, string color, int maxSpeed)
            : base(make, model, color, VehicleType.Car)
        {
            MaxSpeed = maxSpeed;
        }

        public override void Info()
        {
            Console.WriteLine($"{Type}: {Make} {Model} {Color}, Max speed: {MaxSpeed}");
        }
    }
}