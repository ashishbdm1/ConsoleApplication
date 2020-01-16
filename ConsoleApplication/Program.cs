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
            myLocation = Console.ReadLine();

            Console.WriteLine($"My name is:{myName}");
            Console.WriteLine($"My location is:{myLocation}");

            var currentDate = DateTime.Now;
            Console.WriteLine($"The current date is: { currentDate.ToString("ddd, dd MMM yyy")}");

            var christmas = new DateTime(currentDate.Year, 12, 25);
            var daysTillChristmas = currentDate - christmas;

            Console.WriteLine("Dayes untill Christmas is: " + daysTillChristmas.ToString("dd"));

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please enter height ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
