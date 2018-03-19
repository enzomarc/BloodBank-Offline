using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using BB_App.Models;

namespace BB_App.Models
{
    public class User
    {

        #region Fields

        private int _id, _phone;
        private string _name, _password, _bloodgroup, _gender, _city;
        private DateTime _birthdate;

        #endregion

        // Constructor
        public User(int id)
        {

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                string query = "SELECT * FROM users WHERE id_user = " + id;
                MySqlCommand cmd = new MySqlCommand(query, SqlConnection.conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    _id = (int)rdr[0];
                    Name = rdr[1].ToString();
                    Phone = (int)rdr[2];
                    Password = rdr[3].ToString();
                    BloodGroup = rdr[4].ToString();
                    BirthDate = (DateTime)rdr[5];
                    Gender = rdr[6].ToString();
                    City = rdr[7].ToString();
                }
            }

        }

        #region Properties

        public int Id
        {
            get { return _id; }
        }

        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string BloodGroup
        {
            get { return _bloodgroup; }
            set { _bloodgroup = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        #endregion

        #region Methods

        public static string getUserName(int id)
        {
            string username = "";

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                string query = "SELECT name FROM users WHERE id_user = " + id;
                MySqlCommand cmd = new MySqlCommand(query, SqlConnection.conn);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    username = result.ToString();
                }
                else
                    username = "";
            }

            return username;
        }

        #endregion

    }
}
