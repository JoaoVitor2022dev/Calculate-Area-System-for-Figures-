using System; 
using ConsoleApp1.Model.Entities;
using ConsoleApp1.Model.Enums;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle(2.0, Color.White);
            //{ Radius = 2.0, Color = Color.White };

            Shape s2 = new Rectangle(3.5, 4.5, Color.White);


            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
