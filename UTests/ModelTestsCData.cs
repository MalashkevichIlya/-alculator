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

    public class ModelTestsCData
    {
        readonly double[][] tArray = [
            [1,2],
            [6,2,3],
            [7,1,2],
            [8,10,1000,2]
        ];


        [Fact]
        public void AddOperation_CorrectSum()
        {
            double[] tResalts = [3, 11, 10, 1020];
            for (int i = 0; i < tArray.Length; i++)
            {
                var operation = new AddOperation();
                Assert.Equal(tResalts[i], operation.Call(tArray[i]));
            }
        }

        [Fact]
        public void SubtractOperation_CorrectDifference()
        {
            double[] tResalts = [-1, 1, 4, -1004];
            for (int i = 0; i < tArray.Length; i++)
            {
                var operation = new SubtractOperation();
                Assert.Equal(tResalts[i], operation.Call(tArray[i]));
            }
        }

        [Fact]
        public void MultiplyOperation_CorrectProduct()
        {
            double[] tResalts = [2, 36, 14, 160000];
            for (int i = 0; i < tArray.Length; i++)
            {
                var operation = new MultiplyOperation();
                Assert.Equal(tResalts[i], operation.Call(tArray[i]));
            }
        }

        [Fact]
        public void DivideOperation_CorrectQuotient()
        {
            double[] tResalts = [0.5, 1, 3.5, 0.0004];
            for (int i = 0; i < tArray.Length; i++)
            {
                var operation = new DivideOperation();
                Assert.Equal(tResalts[i], operation.Call(tArray[i]));
            }
        }

        [Fact]
        public void PowOperation_CorrectPower()
        {
            double[] tResalts = [1, 36, 7, 1073741824];
            for (int i = 0; i < tArray.Length; i++)
            {
                var operation = new PowOperation();
                Assert.Equal(tResalts[i], operation.Call(tArray[i]));
            }
        }
    }
}
