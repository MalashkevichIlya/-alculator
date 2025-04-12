using Xunit;
using Moq;
using Model;

namespace Tests
{
    public class MoqOperationsRegistryTests
    {
        [Theory]
        [InlineData(1, 2, "+", 3)]
        [InlineData(1, 2, "-", -1)]
        [InlineData(1, 2, "*", 2)]
        [InlineData(1, 2, "/", 0.5)]
        public void PerformOperations_WhenCorrectDataPassed_ShouldReturnCorrectResult(double value1, double value2, string operation, double expected)
        {
            // Arrange
            double[] input = [value1, value2];


            var moq = new Mock<IOperation>();
            moq.Setup(op => op.Call(input)).Returns(expected);

            OperationsRegistry.Operations[operation] = moq.Object;

            // Act
            var result = OperationsRegistry.PerformOperation(operation, input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
