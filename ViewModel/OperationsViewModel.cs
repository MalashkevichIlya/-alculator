using System.ComponentModel;
using System.Runtime.CompilerServices;
using Model;

namespace ViewModel
{
    public class OperationsViewModel : IOperationsViewModel
    {
        public string Input { get; set; } = string.Empty;

        public string ExecuteOperation(string operation)
        {
            try
            {
                return OperationsRegistry.PerformOperation(operation, Input.Split(' ').Select(double.Parse).ToArray()).ToString();
            }
            catch (Exception ex)
            {
                return $"Исключение: {ex.Message}";
            }
        }

        //нужно для WPF или MAUI
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
