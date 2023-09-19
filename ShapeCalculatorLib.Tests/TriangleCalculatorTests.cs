namespace ShapeCalculatorLib.Tests
{
    public class TriangleCalculatorTests
    {
        [Fact]
        public void CalculateArea_ValidTriangle3_4_5_ReturnsCorrectArea_6()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expectedArea = 6;

            // Act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, actualArea);
        }

        [Fact]
        public void IsRightTriangle_RightTriangle3_4_5_ReturnsTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5; // Правильный прямоугольный треугольник

            // Act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool isRightTriangle = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void IsValidTriangle_NotValidTriangle3_4_8_ReturnsFalse()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 8;

            // Act
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            bool isRightTriangle = triangle.IsValidTriangle();

            // Assert
            Assert.False(isRightTriangle);
        }
    }
}
