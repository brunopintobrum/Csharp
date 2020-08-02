using Inheritance_Abstract_Methods_Exemple.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Abstract_Methods_Exemple.Entities
{
    class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle()
        {
        }

        public Triangle(double @base, double height, Color color) : base(color)
        {
            Base = @base;
            Height = height;
        }

        public override double Area()
        {
            return Base * Height / 2;
        }
    }
}
