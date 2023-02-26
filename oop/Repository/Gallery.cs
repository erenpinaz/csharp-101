using OOP.Model;

namespace OOP.Repository
{
    public class Gallery : IGallery
    {

        public List<Vehicle> Assets { get; set; }

        public Gallery()
        {
            Assets = new List<Vehicle>();
        }

        public void Add(Vehicle vehicle)
        {
            Assets.Add(vehicle);
            Console.WriteLine("Vehicle added.");
        }

        public void StockInfo()
        {
            foreach (var vehicle in Assets)
            {
                vehicle.Info();
            }
        }
    }
}