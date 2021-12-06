using FinalApp.Command;
using FinalApp.Model;
using FinalApp.Views;
using Prism.Mvvm;
using System.Windows;
using System.Windows.Controls;

namespace FinalApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
      
        private string _title = "Final app";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private string _loginButton = "Login";
        public string LoginButton
        {
            get { return _loginButton; }
            set { _loginButton = value; }
        }
        private string _generalButton = "General";

        public string GeneralButton
        {
            get { return _generalButton ; }
            set { _generalButton = value; }
        }
        private string _exitButton = "Exit";

        public string ExitButton
        {
            get { return _exitButton; }
            set { _exitButton = value; }
        }

        private string _registrationButton = "Registration";

        public string RegistrationButton
        {
            get { return _registrationButton; }
            set { _registrationButton = value; }
        }






    }


}
    
