using FinalApp.Model;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows;

namespace FinalApp.ViewModels
{
    class ArticlesViewModel : INotifyPropertyChanged
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
                OnPropertyChanged("SelectedArticleBody");
            }
        }

        private ObservableCollection<ArticleModel> _articles;

        public ObservableCollection<ArticleModel> Articles
        {
            get
            {
                return _articles;
            }
            set
            {
                _articles = value;
            }
        }
        private ArticleModel _selectedArticle;

        public ArticleModel SelectedArticle
        {
            get { return _selectedArticle; }
            set
            {
                _selectedArticle = value;
                OnPropertyChanged("SelectedArticle");
                OnPropertyChanged("SelectedArticleBody");
            }
        }
        
        private string _selectedArticleBody;


        public string SelectedArticleBody
        {
            get
            {
                if (Name == String.Empty)
                {
                    return Name = "miauauauaua";
                }
                else
                {
                    return Name;
                }
                //if (SelectedArticle != null)
                //{

                //    return SelectedArticle.ArticleBody;
                //}
                //else
                //{
                //    return _selectedArticleBody;

                //}


            }
            set
            {
                _selectedArticleBody = value;
                OnPropertyChanged("SelectedArticleBody");
            }
        }
        public ArticlesViewModel()
        {
            


        }


        public ArticlesViewModel(ObservableCollection<ArticleModel> listas)
        {
            Articles = listas;

            //Articles = new ObservableCollection<ArticleModel>()
            //{

            // new ArticleModel() { ArticleBody = "miau", Title = "Nirav" }
            //,new ArticleModel() { ArticleBody = "miau", Title = "Kapil" }
            //,new ArticleModel() { ArticleBody = "miau", Title = "Arvind" }
            //,new ArticleModel() { ArticleBody = "miau", Title = "Rajan" }
            //};

        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

    }

}
