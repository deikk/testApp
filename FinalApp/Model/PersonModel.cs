using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalApp.Model
{
    public class PersonModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Represents one person
        /// </summary>
        /// 
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged("UserName");
            }
        }
       
        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _emailAddress;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }
        public PersonModel(string userName, string city, string gender, string emailAddress)
        {
            UserName = userName;
            City = city;
            Gender = gender;
            EmailAddress = emailAddress;
        }
        public PersonModel(int id, string userName, string city, string gender, string emailAddress)
        {
            Id = id;
            UserName = userName;
            City = city;
            Gender = gender;
            EmailAddress = emailAddress;
        }
        public PersonModel()
        {

        }
        public PersonModel(string username, string emailAddress)
        {
            UserName = username;
            EmailAddress = emailAddress;
        }


    }
}
