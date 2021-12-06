using FinalApp.Model;
using FinalApp.ViewModels;
using System.Windows;
using System.Windows.Controls;
using FinalApp.DataAccess;

namespace FinalApp.Views
{
    /// <summary>
    /// Interaction logic for ViewLogin
    /// </summary>
    public partial class ViewRegistration : UserControl
    {
        public ViewRegistration()
        {
            InitializeComponent();
            
        }

        private void registerButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (validateForm())
            {
                PersonModel person = new PersonModel(userNameValue.Text, cityValue.Text, genderValue.Text, emailAddress.Text);
                SqlConnector.CreatePerson(person);
                MessageBox.Show("Registration was successfull");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
        private bool validateForm()
        {
            bool output = false;
            if (userNameValue.Text.Length > 0 && userNameValue.Text.Length < 20)
            {
                output = true;
            }
            return output;
        }

        private void userNameValue_GotFocus_1(object sender, RoutedEventArgs e)
        {
            userNameValue.Text = "";
        }
    }
}
