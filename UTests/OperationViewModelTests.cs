using ViewModel;
using Xunit;

namespace Tests
{
    public class OperationViewModelTests
    {
        [Fact]
        public void ExecuteOperation_WhenIncorrectDataPassed_ShouldReturnExceptionMessage()
        {
            //Arrange 
            var operation = new OperationsViewModel();
            var input = "F F";
            var expected = "Исключение: The input string '' was not in a correct format.";

            //Act
            var result = operation.ExecuteOperation(input);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
