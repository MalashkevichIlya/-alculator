using View;
using Xunit;

namespace Tests
{
    public class ConsoleViewTests
    {
        [Fact]
        public void StringCheck_ShouldReturnTrue_WhenInputIsNull()
        {
            //Arrange 
            var value = String.Empty;

            // Act
            bool result = ConsoleView.StringCheck(value);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void StringCheck_ShouldReturnTrue_WhenInputIsEmpty()
        {
            //Arrange 
            var value = " ";

            // Act
            bool result = ConsoleView.StringCheck(value);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void StringCheck_ShouldReturnFalse_WhenInputIsValid()
        {
            //Arrange 
            var value = "1 2";

            // Act
            bool result = ConsoleView.StringCheck(value);

            // Assert
            Assert.False(result);
        }
    }
}



