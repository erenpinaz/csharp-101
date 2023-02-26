using OOP.Enum;

namespace OOP.Model
{
    sealed class Truck : Vehicle
    {
        public int MaxLoad { get; set; }

        public Truck(string make, string model, string color, int maxLoad)
            : base(make, model, color, VehicleType.Truck)
        {
            MaxLoad = maxLoad;
        }

        public override void Info()
        {
            Console.WriteLine($"{Type}: {Make} {Model} {Color}, Max load: {MaxLoad}");
        }
    }
}