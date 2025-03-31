using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class OperationsViewModel : IOperationsViewModel
    {
        public string Input { get; set; } = "";

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
