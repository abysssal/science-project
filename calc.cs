// To run, write "dotnet run" in the terminal
using System.IO.Compression;
using System;

namespace calc
{
    class Program
    {
        public static double x { get; set;} = 20.0;
        public static double y { get; set;} = 65.0;
        public static double z { get; set;} = 234.43878;
        public static double ans { get; set;} = 0.0;

        public static void Main(string[] args) 
        {
            Console.WriteLine("Here a couple variables used:");
            Console.WriteLine("x is 20.0");
            Console.WriteLine("y is 65.0");
            Console.WriteLine("z is 234.43878");

            Console.WriteLine("We are looking for approximately 7000");

            Console.WriteLine("Starting the calculations in C#..");

            Console.WriteLine("x = x * 4");
            x = x * 4;
            Console.WriteLine("x equals " + x);

            Console.WriteLine("x = y / 25.2842");
            x = y / 25.2842;
            Console.WriteLine("x equals " + x);

            Console.WriteLine("y = x * 23");
            y = x * 23;
            Console.WriteLine("y equals " + y);

            Console.WriteLine("y = y * z / x");
            y = y * z / x;
            Console.WriteLine("y equals " + y);

            Console.WriteLine("z = z * (x + 5 - 0.2432)");
            z = z * (x + 5 - 0.2432);
            Console.WriteLine("z equals " + z);

            Console.WriteLine("z = z + y + z");
            z = z + y + x;
            Console.WriteLine("z equals " + z);
            
            ans = z;
            Console.WriteLine("Our answer is..");
            Console.WriteLine(ans + "!");
        }
    }
}
    