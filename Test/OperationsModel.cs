using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    interface IOperation
    {
        double Call(params double[] args);
    }

    class AddOperation : IOperation
    {
        public double Call(params double[] args) => args[0] + args[1];
    }

    class SubtractOperation : IOperation
    {
        public double Call(params double[] args) => args[0] - args[1];
    }

    public class MultiplyOperation : IOperation
    {
        public double Call(params double[] args) => args[0] * args[1];
    }

    public class DivideOperation : IOperation
    {
        public double Call(params double[] args) => args[0] / args[1];
    }

    public class SinOperation : IOperation
    {
        public double Call(params double[] args) => Math.Sin(args[0]);
    }

    public class CosOperation : IOperation
    {
        public double Call(params double[] args) => Math.Cos(args[0]);
    }

    public class PowOperation : IOperation
    {
        public double Call(params double[] args) => Math.Pow(args[0], args[1]);
    }
}
