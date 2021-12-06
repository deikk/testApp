using FinalApp.Model;
using FinalApp.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace FinalApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(loginUserControl);
        }

        private void GeneralButtonClick(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(generalUserControl);
        }

        private void RegistrationButtonClick(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(registrationUserControl);
        }
        public void SetActiveUserControl(UserControl control)
        {
            loginUserControl.Visibility = Visibility.Collapsed;
            registrationUserControl.Visibility = Visibility.Collapsed;
            generalUserControl.Visibility = Visibility.Collapsed;

            control.Visibility = Visibility.Visible;
            
        }

    }
}


