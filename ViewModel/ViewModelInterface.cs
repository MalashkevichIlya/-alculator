using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public interface IOperationsViewModel : INotifyPropertyChanged
    {
        string Input { get; set; }
        string ExecuteOperation(string operation);
    }
}
