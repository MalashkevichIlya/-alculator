using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class OperationsRegistry
    {
        public static readonly Dictionary<string, IOperation> Operations = new()
        {
            { "+", new AddOperation() },
            { "-", new SubtractOperation() },
            { "*", new MultiplyOperation() },
            { "/", new DivideOperation() },
            { "sin", new SinOperation() },
            { "cos", new CosOperation() },
            { "pow", new PowOperation() }
        };

        public static double PerformOperation(string operation, double[] numbers)
        {
            if (Operations.TryGetValue(operation, out var op))
            {
                return op.Call(numbers);
            }
            throw new InvalidOperationException("Операция не найдена");
        }
    }
}
