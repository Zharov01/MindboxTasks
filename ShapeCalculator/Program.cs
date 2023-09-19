using ShapeCalculatorLib;

class Program
{
    static void Main()
    {
        try
        {
            double radius = 5;
            Console.WriteLine($"Вычисление площади круга с радиусом {radius}");
            Circle circle = new Circle(radius);
            Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");
            Console.WriteLine(new string('_', 30));


            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Console.WriteLine($"Вычисление площади треугольника со сторонами: {sideA} , {sideB}, {sideC}");
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Console.WriteLine(triangle.IsRightTriangle() == true ? "Прямоугольный треугольник" : "Не прямоугольный треугольник");
            Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
            Console.WriteLine(new string('_', 30));

            Console.WriteLine($"Вычисление площади фигуры без знания типа во время компиляции");
            ShapeCalculator calculator = new ShapeCalculator();
            string shape = new Random().Next(2) == 1 ? "Круг" : "Треугольник";
            Console.WriteLine($"Площадь динамически определенной фигуры ({shape}): {calculator.CalculateArea(string.Equals(shape, "Круг") ? circle : triangle)}");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}