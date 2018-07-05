using static BB_App.Core.Models.SqlConnection;
using static BB_App.Core.Models.Consts;
using MySql.Data.MySqlClient;
using System;

namespace BB_App.Core.Models
{
    class Notifications
    {

        public static bool AddNotification(int to, string content, string title = null, int seen = 0)
        {
            if (!Connect(Server, DbUser, DbPassword, DbName)) return false;

            const string query = "INSERT INTO notifications (user, title, content, date, seen) VALUES (@to, @title, @content, @date, @seen)";

            var command = new MySqlCommand(query, Conn);
            var date = DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day;
            command.Prepare();
            command.Parameters.AddWithValue("@to", to);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@content", content);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@seen", seen);

            return command.ExecuteNonQuery() > 0;
        }

    }
}
