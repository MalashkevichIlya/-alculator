using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UTests
{

    public class ModelTestsUcData
    {
        [Fact]
        public void PowOperation_CorrectZeroPower()
        {
            var operation = new PowOperation();
            Assert.Equal(1, operation.Call(777, 0));
        }

        [Fact]
        public void DivideOperation_DivideByZeroException()
        {
            var operation = new DivideOperation();
            Assert.Throws<DivideByZeroException>(() => operation.Call(777, 0));
        }

        [Fact]
        public void DivideOperation_ArgumentException()
        {
            var operation = new DivideOperation();
            Assert.Throws<ArgumentException>(() => operation.Call(1));
        }

        [Fact]
        public void UnexpectedOperation()
        {
            Assert.Throws<InvalidOperationException>(() => OperationsRegistry.PerformOperation("test", [1, 2]));
        }
    }
}
