using FinalApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FinalApp.ViewModels;
using System.Data;
using System.Configuration;
using Dapper;
using MongoDB.Driver;
using System.Web.UI.MobileControls;
using System.Data.SqlClient;
using Xamarin.Forms;
using Caliburn.Micro;
using System.Collections.ObjectModel;

namespace FinalApp.DataAccess
{
    public class SqlConnector
    {
        private const string database = "dbCon";
        public static PersonModel CreatePerson(PersonModel person)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings[database].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@UserName", person.UserName);
                p.Add("@City", person.City);
                p.Add("@Gender", person.Gender);
                p.Add("@EmailAddress", person.EmailAddress);

                connection.Execute("dbo.spPerson_Insert", p, commandType: CommandType.StoredProcedure);
            }
            return person;
        }
        public static List<PersonModel> returnPeople()
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings[database].ConnectionString))
            {
                connection.Open();
                SqlCommand sqlcon = new SqlCommand("spPerson_Select", connection);
                sqlcon.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlcon.ExecuteReader();

                List<PersonModel> personListas = new List<PersonModel>();
                PersonModel model = null;
                while (reader.Read())
                {
                    model = new PersonModel();
                    model.Id = Convert.ToInt32(reader["id"].ToString());
                    model.UserName = reader["username"].ToString();
                    model.City = reader["city"].ToString();
                    model.Gender = reader["gender"].ToString();
                    model.EmailAddress = reader["emailaddress"].ToString();
                    personListas.Add(model);
                }
                connection.Close();
                return personListas;
            }

        }
        public static void UpdatePerson(PersonModel person)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings[database].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@UserName", person.UserName);
                p.Add("@City", person.City);
                p.Add("@Gender", person.Gender);
                p.Add("@EmailAddress", person.EmailAddress);
                p.Add("@Id", person.Id);

                connection.Execute("dbo.spPerson_Update", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static void DeletePerson(int ID)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings[database].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@Id", ID);

                connection.Execute("dbo.spPerson_Delete", p, commandType: CommandType.StoredProcedure);
            }
        }
        public static ArticleModel CreateArticle(ArticleModel article)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings[database].ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("@title", article.Title);
                p.Add("@articleBody", article.ArticleBody);
                p.Add("@money", article.Money);

                connection.Execute("dbo.spArticle_Insert", p, commandType: CommandType.StoredProcedure);
            }

            return article;
        }
        public static PersonModel UserExists(PersonModel person)
        {
            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings[database].ConnectionString))
            {
                connection.Open();
                SqlCommand sqlcon = new SqlCommand("spPerson_Exists", connection);
                sqlcon.Parameters.AddWithValue("@username", person.UserName);
                sqlcon.Parameters.AddWithValue("@emailAddress", person.EmailAddress);
                sqlcon.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sqlcon.ExecuteReader();

                PersonModel model = null;
                while (reader.Read())
                {
                    model = new PersonModel();
                    model.Id = Convert.ToInt32(reader["id"].ToString());
                    model.UserName = reader["username"].ToString();
                    model.City = reader["city"].ToString();
                    model.Gender = reader["gender"].ToString();
                    model.EmailAddress = reader["emailaddress"].ToString();

                }
                connection.Close();
                return model;
            }
        }
        public static ObservableCollection<ArticleModel> returnArticles(PersonModel person)
        {
            using(SqlConnection connection = new System.Data.SqlClient.SqlConnection(ConfigurationManager.ConnectionStrings[database].ConnectionString))
            {
                connection.Open();
                SqlCommand sql = new SqlCommand("spArticles_Select", connection);
                sql.Parameters.AddWithValue("@usernameId", person.Id);
                sql.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = sql.ExecuteReader();

                ObservableCollection<ArticleModel> articles = new ObservableCollection<ArticleModel>();
                ArticleModel article = null;
                while(reader.Read())
                {
                    article = new ArticleModel();
                    article.Id = Convert.ToInt32(reader["id"].ToString());
                    article.Title = reader["title"].ToString();
                    article.ArticleBody = reader["articlebody"].ToString();
                    article.UserNameId = Convert.ToInt32(reader["usernameId"].ToString());
                    article.Money = Convert.ToDouble(reader["money"].ToString());
                    articles.Add(article);
                }
                connection.Close();
                return articles;
            }
        }
    }
}
