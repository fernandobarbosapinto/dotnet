using CourseExampleMetodoAbstrato.Entities.Enums;

namespace CourseExampleMetodoAbstrato.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color, string typeShape) : base(color, typeShape)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
