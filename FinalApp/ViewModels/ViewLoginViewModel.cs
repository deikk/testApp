using FinalApp.Command;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace FinalApp.ViewModels
{
    public class ViewLoginViewModel : BindableBase
    {
        public exitCommand eButton { get;  private set; }
        public ViewLoginViewModel()
        {
            eButton = new exitCommand(LoginMessage);
        }

        public void LoginMessage()
        {
            MessageBox.Show("is logino view atejas metodas");
        }
    }
}

