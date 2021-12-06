using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Model
{
    public class ArticleModel 
    {
        //asdsadasdsaasdasasd
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        private int _userNameId;
        public int UserNameId
        {
            get
            {
                return _userNameId;
            }
            set
            {
                _userNameId = value;
            }
        }

        private string _articleBody;
        public string ArticleBody
        {
            get
            {
                return _articleBody;
            }
            set
            {
                _articleBody = value;
            }
        }
        private double _money;
        public double Money
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value;
            }
        }
        public ArticleModel(string title, string article, string money)
        {
            Title = title;
            ArticleBody = article;
            Double MoneyOut;
            bool worked = Double.TryParse(money, out MoneyOut);
            if (worked)
            {
                Money = MoneyOut;
            }
        }
        public ArticleModel()
        {

        }
        public ArticleModel(string articleBody, string title)
        {
            ArticleBody = articleBody;
            Title = title;
        }
    }
}
