using Microsoft.Extensions.DependencyInjection;
using ViewModel;

namespace View
{
    class Perogramm
    {
        static void Main()
        {
            var services = new ServiceCollection()
                .AddTransient<IOperationsViewModel, OperationsViewModel>()
                .AddTransient<IView, ConsoleView>();

            using var serviceProvider = services.BuildServiceProvider();

            var view = serviceProvider.GetService<IView>();
            view.Run();
        }
    }
}
