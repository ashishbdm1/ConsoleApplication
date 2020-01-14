using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string myLocation;

            Console.Write("Please enter your name: ");
            myName = Console.ReadLine();

            Console.Write("Please enter your loation: ");
            myLocation =  Console.ReadLine();

            Console.WriteLine($"My name is:{myName}");
            Console.WriteLine($"My location is:{myLocation}");

            var currentDate = DateTime.Now;
            Console.WriteLine("The current date is: " + currentDate.ToLongDateString());

            var christmas = new DateTime(currentDate.Year, 12, 25);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
