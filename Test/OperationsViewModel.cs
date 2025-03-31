using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    
    internal class OperationsViewModel : INotifyPropertyChanged
    {
        //private readonly Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>
        //{
        //    { "+", new AddOperation() },
        //    { "-", new SubtractOperation() },
        //    { "*", new MultiplyOperation() },
        //    { "/", new DivideOperation() },
        //    { "sin", new SinOperation() },
        //    { "cos", new CosOperation() },
        //    { "pow", new PowOperation() }
        //};

        private readonly Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>
    {
        { "+", new Operation(args => args.Length >= 2 ? args.Aggregate((a, b) => a + b) : throw new ArgumentException("Требуется минимум два числа")) },
        { "-", new Operation(args => args.Length >= 2 ? args.Aggregate((a, b) => a - b) : throw new ArgumentException("Требуется минимум два числа")) },
        { "*", new Operation(args => args.Length >= 2 ? args.Aggregate((a, b) => a * b) : throw new ArgumentException("Требуется минимум два числа")) },
        { "/", new Operation(args => args.Length >= 2 ? args.Aggregate((a, b) => b == 0 ? throw new DivideByZeroException() : a / b) : throw new ArgumentException("Требуется минимум два числа")) },
        { "sin", new Operation(args => args.Length >= 1 ? Math.Sin(args[0]) : throw new ArgumentException("Требуется минимум одно число")) },
        { "cos", new Operation(args => args.Length >= 1 ? Math.Cos(args[0]) : throw new ArgumentException("Требуется минимум одно число")) },
        { "pow", new Operation(args => args.Length >= 2 ? Math.Pow(args[0], args[1]) : throw new ArgumentException("Требуется минимум два числа")) }
    };

        private List<double> numbers = [];
        private double result;

        public List<double> Numbers
        {
            get => numbers;
            set { numbers = value; OnPropertyChanged(); }
        }

        public double Result
        {
            get => result;
            private set { result = value; OnPropertyChanged(); }
        }

        //public void ExecuteOperation(string operation)
        //{
        //    if (operations.ContainsKey(operation))
        //    {
        //        Result = operations[operation].Call(Numbers.ToArray());
        //    }
        //    else
        //    {
        //        Console.WriteLine("Неверная операция");
        //    }
        //}

        public double ExecuteOperation(string operation)
        {
            return operations[operation].Call(Numbers.ToArray());
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

