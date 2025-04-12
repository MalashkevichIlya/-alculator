namespace Model
{
    public class AddOperation : Operation
    {
        public AddOperation() : base(args => (args[0] + args[1]), 2) { }
    }

    public class SubtractOperation : Operation
    {
        public SubtractOperation() : base(args => (args[0] - args[1]), 2) { }
    }

    public class MultiplyOperation : Operation
    {
        public MultiplyOperation() : base(args => (args[0] * args[1]), 2) { }
    }

    public class DivideOperation : Operation
    {
        public DivideOperation() : base(args => (args[0] / args[1]), 2) { }

        protected override void ValidateArguments(double[] args)
        {
            base.ValidateArguments(args);
            if ((args[1] == 0))
            {
                throw new DivideByZeroException("Деление на ноль недопустимо");
            }
        }
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
