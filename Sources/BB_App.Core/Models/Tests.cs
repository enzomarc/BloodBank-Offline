using static BB_App.Core.Models.SqlConnection;
using static BB_App.Core.Models.Consts;
using MySql.Data.MySqlClient;
using System;

namespace BB_App.Core.Models
{
    class Tests
    {

        public static bool AddTest(int to, int by, string from, string content)
        {
            if (!Connect(Server, DbUser, DbPassword, DbName)) return false;

            const string query = "INSERT INTO test_results (user, doc, hospital, content, date) VALUES (@to, @by, @from, @content, @date)";

            var command = new MySqlCommand(query, Conn);
            var date = DateTime.Today.Year + "/" + DateTime.Today.Month + "/" + DateTime.Today.Day;
            command.Prepare();
            command.Parameters.AddWithValue("@to", to);
            command.Parameters.AddWithValue("@by", by);
            command.Parameters.AddWithValue("@from", from);
            command.Parameters.AddWithValue("@content", content);
            command.Parameters.AddWithValue("@date", date);

            return command.ExecuteNonQuery() > 0;
        }

    }
}
