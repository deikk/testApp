using Caliburn.Micro;
using FinalApp.DataAccess;
using FinalApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalApp.Views
{
    /// <summary>
    /// Interaction logic for General.xaml
    /// </summary>
    public partial class General : UserControl
    {

        public General()
        {
            InitializeComponent();
            DataContext = new PersonModel();
            datgr.ItemsSource = SqlConnector.returnPeople();
        }

        private void datgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (datgr.SelectedItem != null)
            {
                PersonModel pers = (PersonModel)datgr.SelectedItem;
                username.Text = pers.UserName;
                city.Text = pers.City;
                gender.Text = pers.Gender;
                emailaddress.Text = pers.EmailAddress;
            }
            else
            {
                username.Text = "";
                city.Text = "";
                gender.Text = "";
                emailaddress.Text = "";

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (datgr.SelectedItem != null)
            {
                PersonModel pers = (PersonModel)datgr.SelectedItem;
                int idid = pers.Id;
                PersonModel person = new PersonModel(idid, username.Text, city.Text, gender.Text, emailaddress.Text);
                SqlConnector.UpdatePerson(person);
            }
            else
            {
                MessageBox.Show("Row was not selected", "General", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            datgr.ItemsSource = SqlConnector.returnPeople();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PersonModel person = (PersonModel)datgr.SelectedItem;
            int id = person.Id;
            SqlConnector.DeletePerson(id);
            datgr.ItemsSource = SqlConnector.returnPeople();

        }
    }
}
