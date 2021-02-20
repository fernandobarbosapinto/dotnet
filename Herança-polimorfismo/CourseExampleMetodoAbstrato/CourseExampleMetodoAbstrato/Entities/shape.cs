using CourseExampleMetodoAbstrato.Entities.Enums;

namespace CourseExampleMetodoAbstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public string TypeShape { get; set; }

        protected Shape(Color color, string typeShape)
        {
            Color = color;
            TypeShape = typeShape;
        }

        public abstract double Area();
    }
}
