using System;
using Test;

OperationsViewModel vm = new OperationsViewModel();

while (true)
{
    Console.WriteLine("Выберите операцию:");
    string operation = Console.ReadLine();

    Console.WriteLine("Введите числа через пробел:");
    vm.Numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

    vm.ExecuteOperation(operation.ToLower());

    Console.WriteLine($"Результат: {vm.Result}");
    Console.WriteLine("Нажмите Enter для продолжения или введите 'exit' для выхода.");
    if (Console.ReadLine()?.ToLower() == "exit") break;
}