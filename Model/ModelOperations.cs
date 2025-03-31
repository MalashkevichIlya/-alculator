using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AddOperation : Operation
    {
        public AddOperation() : base(args => args.Aggregate((a, b) => a + b), 2) { }
    }

    public class SubtractOperation : Operation
    {
        public SubtractOperation() : base(args => args.Aggregate((a, b) => a - b), 2) { }
    }

    public class MultiplyOperation : Operation
    {
        public MultiplyOperation() : base(args => args.Aggregate((a, b) => a * b), 2) { }
    }

    public class DivideOperation : Operation
    {
        public DivideOperation() : base(args =>
        {
            if (args.Skip(1).Any(b => b == 0))
                throw new DivideByZeroException("Деление на ноль недопустимо");
            return args.Aggregate((a, b) => a / b);
        }, 2)
        { }
    }

    public class SinOperation : Operation
    {
        public SinOperation() : base(args => Math.Sin(args[0]), 1) { }
    }

    public class CosOperation : Operation
    {
        public CosOperation() : base(args => Math.Cos(args[0]), 1) { }
    }

    public class PowOperation : Operation
    {
        public PowOperation() : base(args => Math.Pow(args[0], args[1]), 2) { }
    }
}
