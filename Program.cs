using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("Please select shape to process or [Q]uit:\n [C]ircle \n [R]ectangle \n [S]quare \n [T]raingle \n");
            string program = (Console.ReadLine());
              

           

                if (program == "q" || program == "Q")
                {
                    Environment.Exit(0);
                }
                else if (program == "c" || program == "C")
                {
                    Console.WriteLine("Please enter circle radius: ");
                    double r = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(r);

                    Console.WriteLine("Please select output: \n [A]rea \n [P]erimeter \n [B]oth\n");
                    string a = (Console.ReadLine());

                    if (a == "a" || a== "A")
                    {
                        Console.WriteLine("Area of circle: " + circle.Area() + "\n");
                    }
                    else if (a == "p" || a == "P")
                    {
                        Console.WriteLine("Perimeter of circle: " + circle.Perimeter() + "\n");
                    }
                    else if (a == "b" || a == "B")
                    {
                        Console.WriteLine("Perimeter of circle: " + circle.Perimeter() + " \n Area of the circle: " + circle.Area() + "\n");
                    }


                }


                else if (program == "r" || program == "R")
                {

                    Console.WriteLine("Please enter rectangle lengh: ");
                    double l = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter rectangle width: ");
                    double w = double.Parse(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(l, w);

                    Console.WriteLine("Please select output: \n [A]rea \n [P]erimeter \n [B]oth\n");
                    string a = (Console.ReadLine());

                    if (a == "a" || a == "A")
                    {
                        Console.WriteLine("Area of rectangle: " + rectangle.Area() + "\n");
                    }
                    else if (a == "p" || a == "P")
                    {
                        Console.WriteLine(" Perimeter of rectangle: " + rectangle.Perimeter() + "\n");
                    }
                    else if (a == "b" || a == "B")
                    {
                        Console.WriteLine("Perimeter of rectangle: " + rectangle.Perimeter() + " \n Area of the rectagle: " + rectangle.Area() + "\n");
                    }


                }

                else if (program == "s" || program == "S")
                {
                    Console.WriteLine("Please enter side of square: ");
                    double side = double.Parse(Console.ReadLine());

                    Square square = new Square(side);

                    Console.WriteLine("Please select output: \n [A]rea \n [P]erimeter \n [B]oth\n");
                    string a = (Console.ReadLine());

                    if (a == "a" || a == "A")
                    {
                        Console.WriteLine("Area of square: " + square.Area() + "\n");
                    }
                    else if (a == "p")
                    {
                        Console.WriteLine(" Perimeter of square: " + square.Perimeter() + "\n");
                    }
                    else if (a == "b")
                    {
                        Console.WriteLine("Perimeter of square: " + square.Perimeter() + " \n Area of the square: " + square.Area() + "\n");
                    }
                }

                else if (program == "t" || program == "T")
                {
                    Console.WriteLine("Please enter triangle side a: ");
                    double aside = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter triangel side b: ");
                    double bside = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter triangel side c: ");
                    double cside = double.Parse(Console.ReadLine());

                    Triangle triangle = new Triangle(aside, bside, cside);

                    Console.WriteLine("Please select output: \n [A]rea \n [P]erimeter \n [B]oth\n");
                    string a = (Console.ReadLine());

                    if (a == "a" || a == "A")
                    {
                        Console.WriteLine("Area of triange: " + triangle.Area() + "\n");
                    }
                    else if (a == "p" || a == "P")
                    {
                        Console.WriteLine(" Perimeter of triange: " + triangle.Perimeter() + "\n");
                    }
                    else if (a == "b" || a == "B")
                    {
                        Console.WriteLine("Perimeter of triange: " + triangle.Perimeter() + " \n Area of the triange: " + triangle.Area() + "\n");
                    }
                }
            }
        }
    }
}
