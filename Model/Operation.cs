namespace Model
{
    public delegate double OperationDelegate(params double[] args);

    public abstract class Operation : IOperation
    {
        private readonly OperationDelegate _operation;
        private readonly int _minArgs;

        protected Operation(OperationDelegate operation, int minArgs)
        {
            _operation = operation;
            _minArgs = minArgs;
        }

        public double Call(params double[] args)
        {
            ValidateArguments(args);
            return _operation(args);
        }

        protected virtual void ValidateArguments(double[] args)
        {
            if (args.Length < _minArgs)
            {
                throw new ArgumentException($"Ожидалось минимум {_minArgs} числа");
            }
        }
    }
}
