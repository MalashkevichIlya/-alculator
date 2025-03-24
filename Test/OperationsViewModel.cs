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
        private readonly Dictionary<string, IOperation> operations = new Dictionary<string, IOperation>
    {
        { "+", new AddOperation() },
        { "-", new SubtractOperation() },
        { "*", new MultiplyOperation() },
        { "/", new DivideOperation() },
        { "sin", new SinOperation() },
        { "cos", new CosOperation() },
        { "pow", new PowOperation() }
    };

        private List<double> numbers = new List<double>();
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

        public void ExecuteOperation(string operation)
        {
            if (operations.ContainsKey(operation))
            {
                Result = operations[operation].Call(Numbers.ToArray());
            }
            else
            {
                Console.WriteLine("Неверная операция");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

