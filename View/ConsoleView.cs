using ViewModel;

namespace View
{
    public class ConsoleView(IOperationsViewModel viewModel) : IView
    {
        private readonly IOperationsViewModel _viewModel = viewModel;

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Выберите операцию (+, -, *, /, sin, cos, pow):");
                var operation = Console.ReadLine();

                if(StringCheck(operation))
                    continue;

                Console.WriteLine("Введите числа через пробел:");
                var input = Console.ReadLine();

                if (StringCheck(input))
                    continue;

                _viewModel.Input = input;

                try
                {
                    Console.WriteLine($"Результат: {_viewModel.ExecuteOperation(operation.ToLower())}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Исключение: {ex.Message}");
                    Console.WriteLine();
                }

                Console.WriteLine("Нажмите Enter для продолжения или введите 'exit' для выхода.");
                if (Console.ReadLine()?.ToLower() == "exit") break;
            }
        }

        public static bool StringCheck(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ввведена пустая строка!");
                Console.WriteLine();
                return true;
            }
            return false;
        }
    }
}



