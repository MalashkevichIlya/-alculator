using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace View
{
    class Perogramm
    {
        static void Main()
        {
            IOperationsViewModel viewModel = new OperationsViewModel();
            ConsoleView view = new(viewModel);
            view.Run();
        }
    }
}
