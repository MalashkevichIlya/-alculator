using System.ComponentModel;

namespace ViewModel
{
    public interface IOperationsViewModel : INotifyPropertyChanged
    {
        string Input { get; set; }
        string ExecuteOperation(string operation);
    }
}
