using System;
using BB_App.Core.Properties;
using MySql.Data.MySqlClient;

namespace BB_App.Core.Models
{
    public class User
    {
        // Constructor
        public User(int id)
        {
            if (!SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return;

            var query = "SELECT * FROM users WHERE id_user = " + id;
            var cmd = new MySqlCommand(query, SqlConnection.Conn);
            var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Id = (int) rdr[0];
                Name = rdr[1].ToString();
                Phone = (int) rdr[2];
                Password = rdr[3].ToString();
                BloodGroup = rdr[4].ToString();
                BirthDate = (DateTime) rdr[5];
                Gender = rdr[6].ToString();
                City = rdr[7].ToString();
            }
        }

        #region Methods

        public static string GetUserName(int id)
        {
            var username = "";

            if (!SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return username;

            var query = "SELECT name FROM users WHERE id_user = " + id;
            var cmd = new MySqlCommand(query, SqlConnection.Conn);

            var result = cmd.ExecuteScalar();

            username = result?.ToString() ?? "";

            return username;
        }

        #endregion

        #region Fields

        #endregion

        #region Properties

        public int Id { get; }

        public int Phone { get; set; }

        public string Name { get; set; }

        public string BloodGroup { get; set; }

        public string Password { get; set; }

        public string Gender { get; set; }

        public string City { get; set; }

        public DateTime BirthDate { get; set; }

        #endregion
    }
}