using CourseExampleMetodoAbstrato.Entities.Enums;
using System;
namespace CourseExampleMetodoAbstrato.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color, string typeShape) : base(color, typeShape)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
