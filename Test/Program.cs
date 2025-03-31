using System;
using Test;

OperationsViewModel vm = new OperationsViewModel();

while (true)
{
    Console.WriteLine("Выберите операцию (+, -, *, /, sin, cos, pow):");
    string operation = Console.ReadLine();

    Console.WriteLine("Введите числа через пробел:");

    try
    {
        vm.Numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
    }
    catch(FormatException)
    {
        Console.WriteLine("Ошибка ввода");
        continue;
    }


    //vm.ExecuteOperation(operation.ToLower());
    //Console.WriteLine($"Результат: {vm.Result}");

    Console.WriteLine($"Результат: {vm.ExecuteOperation(operation.ToLower())}");
    Console.WriteLine("Нажмите Enter для продолжения или введите 'exit' для выхода.");
    if (Console.ReadLine()?.ToLower() == "exit") break;
}