namespace ShapeCalculatorLib.Tests
{
    public class CircleCalculatorTests
    {
        [Fact]
        public void CalculateCircleArea_ValidRadius5_ReturnsCorrectArea78_5()
        {
            // Arrange
            double radius = 5;
            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Circle circle = new Circle(radius);

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }
    }
}
