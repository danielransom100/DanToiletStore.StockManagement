using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DanToiletStore.StockManagement.UI.Utility
{
    public class CustomCommand: ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public CustomCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }


        public bool CanExecute(object parameter)
        {
            var b = _canExecute == null || _canExecute(parameter);
            return b;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
