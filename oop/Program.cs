using System;
using System.Text;
using System.IO;
using OOP.Model;
using OOP.Repository;
using OOP.Enum;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var gallery = new Gallery();
                var data = File.ReadLines("gallery.txt");
                foreach (var line in data)
                {
                    var cells = line.Split(',');
                    switch (cells[0])
                    {
                        case nameof(VehicleType.Car):
                            gallery.Add(new Car(cells[1], cells[2], cells[3], Int32.Parse(cells[4])));
                            break;
                        case nameof(VehicleType.Truck):
                            gallery.Add(new Truck(cells[1], cells[2], cells[3], Int32.Parse(cells[4])));
                            break;
                        default:
                            throw new Exception("Unknown vehicle type encountered.");
                    }
                }
                gallery.StockInfo();
            }
            catch
            {
                Console.WriteLine("Any exception should be handled here.");
            }
            finally
            {
                Console.WriteLine("Resources should be released here.");
            }
        }
    }
}