using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

/* ====================================
 * Management of SQL Database Class
 * By : eMarc
 * At : 11/03/2018
 * ===================================
*/

namespace BB_App.Models
{
    class SqlConnection
    {

        public static MySqlConnection conn = new MySqlConnection();

        #region Methods

        public static bool Connect(string server, string user, string password, string database)
        {
            bool _connected = false;

            try
            {
                if (conn.Ping())
                    _connected = true;
                else
                {
                    conn.ConnectionString = "server=" + server + "; user=" + user + "; password=" + password + "; database=" + database;
                    conn.Open();
                    _connected = conn.Ping();
                }
            }
            catch { _connected = false; }

            return _connected;
        }

        public static void Disconnect()
        {
            try
            {
                conn.Close();
            }
            catch { }
        }

        #endregion

    }
}
