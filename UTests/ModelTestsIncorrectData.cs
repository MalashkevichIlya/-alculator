using Model;
using Xunit;

namespace Tests
{
    public class ModelTestsIncorrectData
    {
        [Fact]
        public void PowOperation_WhenRaisedToTheZeroPower_ReturnsOne()
        {
            //Arrange
            var operation = new PowOperation();
            double[] input = [777, 0];
            var expected = 1;

            //Act
            var result = operation.Call(input);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivideOperation_WhenDividingByZero_ReturnsDivideByZeroException()
        {
            //Arrange
            var operation = new DivideOperation();
            double[] input = [777, 0];
            var expected = "Деление на ноль недопустимо";

            //Act
            var result = Assert.Throws<DivideByZeroException>(() => operation.Call(input));

            //Assert
            Assert.Equal(expected, result.Message);
        }

        [Fact]
        public void DivideOperation_WhenInputContainsLessThanTwo_Values_ReturnsArgumentException()
        {
            //Arrange
            var operation = new DivideOperation();
            var input = 1;
            var expected = "Ожидалось минимум 2 числа";

            //Act
            var result = Assert.Throws<ArgumentException>(() => operation.Call(input)).Message;

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PerformOperation_WhenIncorrectOperationNamePassed_ReturnsUnexpectedOperation()
        {
            //Arrange
            var inputText = "test";
            double[] inputArray = [1, 2];
            var expected = "Операции не существует!";

            //Act
            var result = Assert.Throws<OperationTypeException>(() => OperationsRegistry.PerformOperation(inputText, inputArray));

            //Assert
            Assert.Equal(expected, result.Message);
        }
    }
}
