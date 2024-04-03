﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Q1.Commands
{
    public class DelegateCommand :ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public DelegateCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
                return true;
            else
                return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }
    }
}
