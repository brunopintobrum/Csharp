

using Inheritance_Abstract_Methods_Exemple.Entities.Enums;

namespace Inheritance_Abstract_Methods_Exemple.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape()
        {
        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
