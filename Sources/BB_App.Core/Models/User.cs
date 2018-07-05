using BB_App.Core.Properties;
using MySql.Data.MySqlClient;
using static BB_App.Core.Models.SqlConnection;
using static BB_App.Core.Models.Consts;

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
                BirthDate = rdr[5].ToString();
                Gender = rdr[6].ToString();
                City = rdr[7].ToString();
            }
        }

        #region Methods

        public static string GetUserName(int id)
        {
            var username = "";

            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return username;

            var query = "SELECT name FROM users WHERE id_user = " + id;
            var cmd = new MySqlCommand(query, SqlConnection.Conn);

            var result = cmd.ExecuteScalar();

            username = result?.ToString() ?? "";

            return username;
        }

        public static bool HasBloodgroup(int user)
        {
            var hasbg = true;

            if (!Connect(Server, DbUser, DbPassword, DbName)) return false;

            const string query = "SELECT bloodgroup FROM users WHERE id_user = @user";

            var command = new MySqlCommand(query, Conn);
            command.Prepare();
            command.Parameters.AddWithValue("@user", user);
            var reader = command.ExecuteReader();

            if (reader.HasRows)
                while (reader.Read())
                    hasbg = reader.GetString(0) != "unknow";

            return hasbg;
        }

        public static bool SetBloodgroup(int user, string bloodgroup)
        {
            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return false;

            var query = "UPDATE users SET bloodgroup = @bg WHERE id_user = @id;";

            var cmd = new MySqlCommand(query, Conn);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@bg", bloodgroup);
            cmd.Parameters.AddWithValue("@id", user);

            return cmd.ExecuteNonQuery() > 0;
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

        public string BirthDate { get; set; }

        #endregion
    }
}