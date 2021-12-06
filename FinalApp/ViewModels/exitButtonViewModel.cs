using FinalApp.Command;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FinalApp.ViewModels
{
    public class exitButtonViewModel : BindableBase
    {
        public exitCommand eButton { get; set; }

        public exitButtonViewModel()
        {
            eButton = new exitCommand(OnExecute);
        }
        public void OnExecute()
        {
            Application.Current.Shutdown();
        }
    }
}
