using FinalApp.DataAccess;
using FinalApp.Model;
using System.Windows;
using System.Windows.Controls;

namespace FinalApp.Views
{
    /// <summary>
    /// Interaction logic for ViewLogin
    /// </summary>
    public partial class ViewLogin : UserControl
    {
        public ViewLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            PersonModel person = new PersonModel(userNameValue.Text, PasswordValue.Password);
            PersonModel miau = SqlConnector.UserExists(person);
            if (ValidateForm(miau))
            {
                articles arc = new articles(miau);
                arc.Show();
            }
            else
            {
                MessageBox.Show("User does not exist, check your username or password", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private bool ValidateForm(PersonModel miau)
        {
            bool returnOrNot = false;
            
            if (miau != null && userNameValue.Text.Length != 0 && PasswordValue.Password.Length != 0)
            {
                returnOrNot = true;
            }
            else
            {
                returnOrNot = false;
            }
            return returnOrNot;
        }
    }
}
