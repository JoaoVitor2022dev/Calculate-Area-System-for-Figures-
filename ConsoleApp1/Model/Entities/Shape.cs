using System;
using ConsoleApp1.Model.Enums; 

namespace ConsoleApp1.Model.Entities
{
    abstract internal class Shape
    {
        public Color Color { get; set; }
        public abstract double Area(); 
    }
}
