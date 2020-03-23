using System;

namespace Tutorials_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            double length, width, radius, height, base1, area;
            const double Pi = 3.14159;
            //Introduction to the Audience
            Console.WriteLine("This Program will calutate the area of a Square, Rectangle, Circle, and a Triangle");

            //User Inputs Sqaure
            Console.Write("\n\nArea of a Rectangle/Sqaure...\n ");
            Console.Write("Please enter the length of the Rectangle:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the width of the Rectangle:");
            width = Convert.ToDouble(Console.ReadLine());
            area = length * width;
            Console.Write("The Area of the Rectangle is " + area);

            //User Inputs Circle
            Console.Write("\n\nArea of a Circle...\n ");
            Console.Write("Please enter the radius of the Circle:");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Pi * radius * radius;
            Console.Write("The Area of the Circle is " + area);

            //User Inputs Triangle
            Console.Write("\n\nArea of a Triangle\n ");
            Console.Write("Please enter the base of the Triangle:");
            base1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the height of the Triangle:");
            height = Convert.ToDouble(Console.ReadLine());
            area = 0.5 * base1 * height;
            Console.Write("The Area of the Rectangle is " + area);



            //Pausing the Screen 
            Console.Write("\n\n");

        }
    }
}
