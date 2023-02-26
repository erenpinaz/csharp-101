using OOP.Enum;

namespace OOP.Model
{
    public abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public VehicleType Type { get; private set; }

        public Vehicle(string make, string model, string color, VehicleType type)
        {
            Make = make;
            Model = model;
            Color = color;
            Type = type;
        }

        public abstract void Info();
    }
}