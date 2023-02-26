using System;
using System.Text;

namespace Basics
{
    class Program
    {
        static void Main(string[] args) {
            // Say Hello World!
            Console.WriteLine("Hello World!");

            // Variables
            // char = 16-bit, string = list(char)
            // int, float "F" = 32-bit, long "L", double "D" = 64-bit
            // Scientific notation allowed in float & double (35E3F)
            string name = "Eren";
            int birthYear = 1989, currentYear = DateTime.Now.Year;
            double salary = 30000.00D;

            Console.WriteLine($"I'm {name}. I was born in {birthYear} ({currentYear - birthYear} years old). My monthly income is {salary}.");

            // Type Casting & Conversion
            double doubleSource = 9.78D;
            int castedNumber = (int) doubleSource;
            int convertedNumber = Convert.ToInt32(doubleSource);

            Console.WriteLine($"Cast: {castedNumber}, Convert: {convertedNumber}");

            // Operators
            // + - / * % standard operators
            // > < <= >= == logical operators
            int x = 14, y = 11;

            Console.WriteLine($"Bitwise AND (14&11): {x & y}, Bitwise OR (14|11): {x | y}, Bitwise XOR (14^11): {x ^ y}, Comp 2's (~14): {~x}");
            Console.WriteLine($"Right Shift by 1 (14>>1): {x >> 1}, Left Shift by 1 (14<<1): {x << 1}");

            // Math
            int x2 = 5, y2 = 10, z2 = -3;
            Console.WriteLine($"Max (5,10,-3): {Math.Max(x2, Math.Max(y2, z2))}, Min (5,10,-3): {Math.Min(x2, Math.Min(y2, z2))}, Abs (-3): {Math.Abs(z2)}");

            // String Ops
            string greeting = "Hello World!";
            Console.WriteLine($"Index of W: {greeting.IndexOf('W')}, Concat (Hello+): {string.Concat("Hello ", greeting)}"); // Interpolation

            // String Builder
            // Message Repeater
            var len = 3;
            var message = "hello";
            var sb = new StringBuilder("Repeater: ");
            for (int i = 0; i < len; i++) {
                sb.Append($"{message} {i}{(i != len - 1 ? " | " : string.Empty)}");
            }
            Console.WriteLine(sb.ToString());

            // If & Switch
            // if condition is cool, ternary if is cooler
            Console.WriteLine($"{(20 > 10 ? "Of course!": "Nope!")}");

            int position = 1;
            switch (position) {
                case 0:
                    Console.WriteLine("On");
                    break;
                case 1:
                    Console.WriteLine("Off");
                    break;
                default:
                    Console.WriteLine("Unknown State");
                    break;
            }

            // Loops & Break/Continue
            int counter = 0;
            while(true) {
                counter += 1;

                if(counter < 10)
                    continue;

                break;
            }
            Console.WriteLine($"While loop broken, counter is {counter}");
            
            counter = 0;
            for(int i = 0; i < 10; i+=2) {
                counter++;
            }
            Console.WriteLine($"For loop ended, counter is {counter}");

            string[] cars = {"Audi", "BMW", "Mercedes", "Citroén"};
            foreach (string car in cars) {
                Console.WriteLine(car);
            }

            // Arrays
            int[] nums = new int [10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (var num in nums) {
                Console.Write(num);
            }
            Console.WriteLine($" | nums array length is: {nums.Length}");
        }
    }
}