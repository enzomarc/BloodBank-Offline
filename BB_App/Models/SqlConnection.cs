using MySql.Data.MySqlClient;

/* ====================================
 * Management of SQL Database Class
 * By : eMarc
 * At : 11/03/2018
 * ===================================
*/

namespace BB_App.Models
{
    internal class SqlConnection
    {
        public static readonly MySqlConnection Conn = new MySqlConnection();

        #region Methods

        public static bool Connect(string server, string user, string password, string database)
        {
            bool connected;

            try
            {
                if (Conn.Ping())
                    connected = true;
                else
                {
                    Conn.ConnectionString = "server=" + server + "; user=" + user + "; password=" + password + "; database=" + database;
                    Conn.Open();
                    connected = Conn.Ping();
                }
            }
            catch { connected = false; }

            return connected;
        }

        public static void Disconnect()
        {
            try
            {
                Conn.Close();
            }
            catch
            {
                // ignored
            }
        }

        #endregion Methods
    }
}