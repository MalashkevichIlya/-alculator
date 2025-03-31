using System;
using ViewModel;

namespace View
{
    public class ConsoleView
    {
        private readonly IOperationsViewModel _viewModel;

        public ConsoleView(IOperationsViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию (+, -, *, /, sin, cos, pow):");
                string operation = Console.ReadLine();

                Console.WriteLine("Введите числа через пробел:");
                _viewModel.Input = Console.ReadLine();

                Console.WriteLine($"Результат: {_viewModel.ExecuteOperation(operation.ToLower())}");

                Console.WriteLine("Нажмите Enter для продолжения или введите 'exit' для выхода.");
                if (Console.ReadLine()?.ToLower() == "exit") break;
            }
        }
    }
}



