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

    delegate double OperationDelegate(params double[] args);

    class Operation : IOperation
    {
        private readonly OperationDelegate _operation;

        public Operation(OperationDelegate operation)
        {
            _operation = operation;
        }

        public double Call(params double[] args)
        {
            try
            {
                return _operation(args);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль");
                return double.NaN;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка выполнения операции: {ex.Message}");
                return double.NaN;
            }
        }
    }

    //class AddOperation : IOperation
    //{
    //    public double Call(params double[] args ) => args[0] + args[1];
    //}

    //class SubtractOperation : IOperation
    //{
    //    public double Call(params double[] args) => args[0] - args[1];
    //}

    //public class MultiplyOperation : IOperation
    //{
    //    public double Call(params double[] args) => args[0] * args[1];
    //}

    //public class DivideOperation : IOperation
    //{
    //    public double Call(params double[] args) => args[0] / args[1];
    //}

    //public class SinOperation : IOperation
    //{
    //    public double Call(params double[] args) => Math.Sin(args[0]);
    //}

    //public class CosOperation : IOperation
    //{
    //    public double Call(params double[] args) => Math.Cos(args[0]);
    //}

    //public class PowOperation : IOperation
    //{
    //    public double Call(params double[] args) => Math.Pow(args[0], args[1]);
    //}
}
