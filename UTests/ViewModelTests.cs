using ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UTests
{
    public class ViewModelTests
    {
        [Fact]
        public void ExecuteOperation_Uncorrect()
        {
            var operation = new OperationsViewModel();
            Assert.Equal("Исключение: The input string '' was not in a correct format.", operation.ExecuteOperation("F F"));
        }
    }
}
