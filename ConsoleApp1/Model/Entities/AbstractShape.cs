using System;
using ConsoleApp1.Model.Enums; 

namespace ConsoleApp1.Model.Entities
{
    internal abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area(); 
    }
}
