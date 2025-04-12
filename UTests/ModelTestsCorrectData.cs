using Model;
using Xunit;

namespace Tests
{
    public class ModelTestsCorrectData
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-5, 10, 5)]
        [InlineData(-10, 5, -5)]
        [InlineData(-10, -5, -15)]
        [InlineData(10, 5.5, 15.5)]
        public void AddOperation_WhenCorrectDataPassed_ShouldReturnCorrectResult(double value1, double value2, double expected)
        {
            //Arrange
            var operation = new AddOperation();

            //Act
            var result = operation.Call([value1, value2]);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(1, 2, -1)]
        [InlineData(-10, -5, -5)]
        [InlineData(-5, 10, -15)]
        [InlineData(10, 5.5, 4.5)]
        public void SubtractOperation_WhenCorrectDataPassed_ShouldReturnCorrectResult(double value1, double value2, double expected)
        {
            //Arrange
            var operation = new SubtractOperation();

            //Act
            var result = operation.Call([value1, value2]);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(2, 0, 0)]
        [InlineData(-10, 5, -50)]
        [InlineData(-10, -5, 50)]
        [InlineData(10, 5.5, 55)]
        public void MultiplyOperation_WhenCorrectDataPassed_ShouldReturnCorrectResult(double value1, double value2, double expected)
        {
            //Arrange
            var operation = new MultiplyOperation();

            //Act
            var result = operation.Call([value1, value2]);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(-5, 10, -0.5)]
        [InlineData(-12, 2, -6)]
        [InlineData(-12, -2, 6)]
        [InlineData(1, 2, 0.5)]
        public void DivideOperation_WhenCorrectDataPassed_ShouldReturnCorrectResult(double value1, double value2, double expected)
        {
            //Arrange
            var operation = new DivideOperation();

            //Act
            var result = operation.Call([value1, value2]);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(2, 0, 1)]
        [InlineData(10, -2, 0.01)]
        [InlineData(-10, -2, 0.01)]
        public void PowOperation_WhenCorrectDataPassed_ShouldReturnCorrectResult(double value1, double value2, double expected)
        {
            //Arrange
            var operation = new PowOperation();

            //Act
            var result = operation.Call([value1, value2]);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
