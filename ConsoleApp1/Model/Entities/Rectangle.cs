using System;
using ConsoleApp1.Model.Enums; 
using System.Globalization;

namespace ConsoleApp1.Model.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Color Color { get; set; }
        public Rectangle(double height, double width, Color color)
        {
            Height = height;
            Width  = width;
            Color = color;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return "Cicle Color = " +
                   Color
                   + ", Width = "
                   + Width.ToString("F2", CultureInfo.InvariantCulture)
                   + ", Heigth = "
                   + Height.ToString("F2", CultureInfo.InvariantCulture)
                   + ", Area = "
                   + Area().ToString(CultureInfo.InvariantCulture);
        }
    }
}
