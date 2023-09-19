namespace ShapeCalculatorLib
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            if (Radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
