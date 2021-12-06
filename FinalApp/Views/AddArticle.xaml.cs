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
using System.Windows.Shapes;

namespace FinalApp.Views
{
    /// <summary>
    /// Interaction logic for AddArticle.xaml
    /// </summary>
    public partial class AddArticle : Window
    {
        public AddArticle()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ArticleModel article = new ArticleModel(titleValue.Text, articleBodyValue.Text, moneyValue.Text);

            if (ValidateForm())
            {
                SqlConnector.CreateArticle(article);
                MessageBox.Show("Article has been added");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private bool ValidateForm()
        {
            return true;
        }
    }
}
