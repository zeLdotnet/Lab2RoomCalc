using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. input
            //prompt 
            Console.WriteLine("Yo! Welcome to the Room Calculator!\n");


            // 2. receive info + loop 
            char choice;
            do
            {
                Console.WriteLine("Enter the room's length. ");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the room's width. ");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the room's height. ");
                double height = double.Parse(Console.ReadLine());

                //processing -- equations for area, perimeter and volume
                double area = length * width;
                double perimeter = (length * 2) + (width * 2);
                double vol = length * width * height;

                //output
                Console.WriteLine("\nArea: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + vol + '\n');

                //user choice loop
                Console.WriteLine("Enter 'y' to continue or any other to exit. \n");
                choice = char.Parse(Console.ReadLine());
            } while (choice == 'y');
        }
    }
}
 