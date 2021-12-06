﻿using FinalApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FinalApp.Command
{
    public class loginCommand : ICommand
    {
        Action _execute;
        public loginCommand(Action execute)
        {
            _execute = execute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();

        }
    }
}
