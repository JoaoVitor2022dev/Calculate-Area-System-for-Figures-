using System;
using System.Globalization;
using ConsoleApp1.Model.Enums;

namespace ConsoleApp1.Model.Entities
{
     internal class Circle : AbstractShape
    {
        public double Radius { get; set; }
        public Color Color { get; set; }
        public Circle(double radius, Color color)
        {
            Radius = radius;
            Color = color;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return "Cicle Color = " +
                   Color
                   + ", radius = "
                   + Radius.ToString("F2", CultureInfo.InvariantCulture)
                   + ", Area = "
                   + Area().ToString(CultureInfo.InvariantCulture);
        }
    }
}
