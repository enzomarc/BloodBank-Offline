using System;
using System.Data;
using BB_App.Core.Properties;
using MySql.Data.MySqlClient;

/* =====================================================
 * Class Name : Requests
 * Description : Performing CRUD on requests over the database.
 * Author : Marc Enzo
 * At : 16/03/2018
 * ===================================================== */

namespace BB_App.Core.Models
{
    /// <summary>
    ///     Requests Management Class for the database.
    /// </summary>
    internal class Requests
    {
        /// <summary>
        ///     Represents a set of datas based on request available in the database.
        /// </summary>
        public class Request
        {
            #region Fields

            private readonly int _fromId;

            #endregion Fields

            #region Methods

            /// <summary>
            ///     Load request from the database.
            /// </summary>
            /// <param name="id">id of the request to load</param>
            public void LoadFrom(int id = 0)
            {
                try
                {
                    if (!SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user,
                        Settings.Default.db_pwd, Settings.Default.db_name)) return;

                    string query;

                    if (id != 0)
                        query = "SELECT * FROM requests WHERE id_request = " + id;
                    else
                        query = "SELECT * FROM requests WHERE id_request = " + _fromId;

                    var command = new MySqlCommand(query, SqlConnection.Conn);
                    var reader = command.ExecuteReader();

                    if (!reader.HasRows) return;

                    while (reader.Read())
                    {
                        RequestId = Convert.ToInt32(reader[0]);
                        RequestUser = Convert.ToInt32(reader[1]);
                        HospitalReference = Convert.ToString(reader[2]);
                        RequestDate = Convert.ToDateTime(reader[3]);
                        ExpirationDate = Convert.ToDateTime(reader[4]);
                        Unit = Convert.ToInt32(reader[5]);
                        RequestStatus = Convert.ToString(reader[6]);
                    }

                    reader.Close();
                }
                catch
                {
                    throw new NotImplementedException();
                }
            }

            #endregion Methods

            #region Constructors

            /// <summary>
            ///     Clone of the request object available in the database
            /// </summary>
            /// <param name="reqUser">id of the user who is making request</param>
            /// <param name="hospital">hospital reference from where the request is maded</param>
            /// <param name="reqDate">the day where the request was made</param>
            /// <param name="expDate">the day the request will expires</param>
            /// <param name="qty">the number units of blood the user needs</param>
            /// <param name="status">status message of the request (waiting, cancelled, done)</param>
            public Request(int reqUser, string hospital, DateTime reqDate, DateTime expDate, int qty, string status)
            {
                RequestUser = reqUser;
                Unit = qty;
                HospitalReference = hospital;
                RequestDate = reqDate;
                ExpirationDate = expDate;
                RequestStatus = status;
            }

            /// <summary>
            ///     Clone of the request object available in the database.
            /// </summary>
            /// <param name="id">id of the blood request to load from the database</param>
            public Request(int id = 0)
            {
                _fromId = id;
                LoadFrom();
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            ///     ID of the request.
            /// </summary>
            public int RequestId { get; set; }

            /// <summary>
            ///     ID of the user who makes request.
            /// </summary>
            public int RequestUser { get; set; }

            /// <summary>
            ///     Number units of blood for the request.
            /// </summary>
            public int Unit { get; set; }

            /// <summary>
            ///     Reference of the hospital where the request is passed.
            /// </summary>
            public string HospitalReference { get; set; }

            /// <summary>
            ///     Request status (waiting, cancelled, done).
            /// </summary>
            public string RequestStatus { get; set; }

            /// <summary>
            ///     Request initialization date.
            /// </summary>
            public DateTime RequestDate { get; set; }

            /// <summary>
            ///     Request expiration date.
            /// </summary>
            public DateTime ExpirationDate { get; set; }

            #endregion Properties
        }

        #region Fields

        public static MySqlDataAdapter Adapter;
        public static DataSet Datas = new DataSet();

        #endregion Fields

        #region Methods

        /// <summary>
        ///     Load requests from the database based on the hospital reference.
        /// </summary>
        /// <returns>A dataset that represents a clone of datas from the database.</returns>
        public static DataSet LoadRequests()
        {
            if (!SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return Datas;

            var query = "SELECT * FROM requests WHERE ref_hospital = '" + Settings.Default.reference + "'";
            Adapter = new MySqlDataAdapter(query, SqlConnection.Conn);

            Datas.Clear();
            Adapter.Fill(Datas, "requests");

            return Datas;
        }

        /// <summary>
        ///     Insert request tnto the database.
        /// </summary>
        /// <param name="req">Request to save</param>
        /// <returns>Boolean that represent the insert result.</returns>
        public static bool SaveRequest(Request req)
        {
            // Variaable who checks if the request was saved
            bool saved;

            if (!SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return false;

            var date = req.RequestDate.Year + "-" + req.RequestDate.Month + "-" + req.RequestDate.Day;
            var expDate = req.ExpirationDate.Year + "-" + req.ExpirationDate.Month + "-" + req.ExpirationDate.Day;

            var query =
                "INSERT INTO requests(id_user, ref_hospital, request_date, limit_date, unit, request_status) VALUES (@id, @ref, @date, @exp_date, @qty, @status);";

            var cmd = new MySqlCommand(query, SqlConnection.Conn);
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@id", req.RequestUser);
            cmd.Parameters.AddWithValue("@ref", Settings.Default.reference);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@qty", req.Unit);
            cmd.Parameters.AddWithValue("@status", "waiting");
            cmd.Parameters.AddWithValue("@exp_date", expDate);

            try
            {
                cmd.ExecuteNonQuery();
                saved = true;
            }
            catch
            {
                saved = false;
            }

            return saved;
        }

        /// <summary>
        ///     Change the user who makes the request.
        /// </summary>
        /// <param name="request">id of the request to changes the user</param>
        /// <param name="id">id of the new user</param>
        /// <returns>Boolean that represents the update result.</returns>
        public static bool ChangeUser(int request, int id)
        {
            if (!SqlConnection.Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return false;

            var query = "UPDATE requests SET id_user = " + id + " WHERE id_request = " + request + ";";

            var cmd = new MySqlCommand(query, SqlConnection.Conn);

            cmd.ExecuteNonQuery();

            return true;
        }

        #endregion Methods
    }
}