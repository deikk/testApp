using FinalApp.DataAccess;
using FinalApp.Model;
using FinalApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using ZendeskApi_v2.Requests.HelpCenter;

namespace FinalApp.Views
{
    /// <summary>
    /// Interaction logic for articles.xaml
    /// </summary>
    public partial class articles : Window
    {
        public articles(PersonModel miau)
        {
            var listass = SqlConnector.returnArticles(miau);
            InitializeComponent();
            articlesComboBox.DataContext = new ArticlesViewModel(listass);
            


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddArticle article = new AddArticle();
            article.Show();
        }
    }
}
