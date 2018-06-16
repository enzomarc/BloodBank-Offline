using System;
using System.Data;
using BB_App.Core.Properties;
using MySql.Data.MySqlClient;
using static BB_App.Core.Models.SqlConnection;

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
                    if (!Connect(Settings.Default.server, Settings.Default.db_user,
                        Settings.Default.db_pwd, Settings.Default.db_name)) return;

                    string query;

                    if (id != 0)
                        query = "SELECT * FROM requests WHERE id_request = " + id;
                    else
                        query = "SELECT * FROM requests WHERE id_request = " + _fromId;

                    var command = new MySqlCommand(query, Conn);
                    var reader = command.ExecuteReader();

                    if (!reader.HasRows) return;

                    while (reader.Read())
                    {
                        RequestId = Convert.ToInt32(reader[0]);
                        RequestUser = Convert.ToInt32(reader[1]);
                        HospitalReference = Convert.ToString(reader[2]);
                        RequestDate = Convert.ToDateTime(reader[3]);
                        ReceivedDate = Convert.ToDateTime(reader[4]);
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
            /// <param name="receivedDate">the day the request will expires</param>
            /// <param name="qty">the number units of blood the user needs</param>
            /// <param name="status">status message of the request (waiting, cancelled, done)</param>
            public Request(int reqUser, string hospital, DateTime reqDate, DateTime receivedDate, int qty, string status)
            {
                RequestUser = reqUser;
                Unit = qty;
                HospitalReference = hospital;
                RequestDate = reqDate;
                ReceivedDate = receivedDate;
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
            public DateTime ReceivedDate { get; set; }

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
            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return Datas;

            var query = "SELECT * FROM requests WHERE ref_hospital = '" + Settings.Default.reference + "'";
            Adapter = new MySqlDataAdapter(query, Conn);

            Datas = new DataSet();
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
            bool saved;

            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return false;

            var date = req.RequestDate.Year + "-" + req.RequestDate.Month + "-" + req.RequestDate.Day;
            var receivedDate = req.ReceivedDate.Year == 1 ? null : req.ReceivedDate.Year + "-" + req.ReceivedDate.Month + "-" + req.ReceivedDate.Day;

            var query =
                "INSERT INTO requests(id_user, ref_hospital, request_date, received_date, unit, request_status) VALUES (@id, @ref, @date, @exp_date, @qty, @status);";

            var cmd = new MySqlCommand(query, Conn);
            cmd.Prepare();

            cmd.Parameters.AddWithValue("@id", req.RequestUser);
            cmd.Parameters.AddWithValue("@ref", Settings.Default.reference);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@qty", req.Unit);
            cmd.Parameters.AddWithValue("@status", req.ReceivedDate.Year == 1 ? "waiting" : "completed");
            cmd.Parameters.AddWithValue("@exp_date", receivedDate);

            try
            {
                saved = cmd.ExecuteNonQuery() > 0;
            }
            catch
            {
                saved = false;
            }

            return saved;
        }

        /// <summary>
        /// Validate the request with specified id
        /// </summary>
        /// <param name="request">Id of the request to validate</param>
        /// <returns>Boolean that represents the validation result.</returns>
        public static bool ValidateRequest(int request)
        {
            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return false;

            var date = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
            var query = "UPDATE requests SET request_status = 'completed', received_date = @date WHERE id_request = @id;";

            var cmd = new MySqlCommand(query, Conn);
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@id", request);

            return cmd.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Validate the donation with specified id
        /// </summary>
        /// <param name="donation">Id of the donation to validate</param>
        /// <returns>Boolean that represents the validation result.</returns>
        public static bool ValidateDonation(int donation)
        {
            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return false;

            // var date = DateTime.Today.Year + "-" + DateTime.Today.Month + "-" + DateTime.Today.Day;
            var query = "UPDATE donations SET donation_status = 'completed' WHERE id_donation = @id;";

            var cmd = new MySqlCommand(query, Conn);
            cmd.Prepare();
            // cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@id", donation);

            return cmd.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// Determines whether the user with specified id has pending request
        /// </summary>
        /// <param name="id">Id of the user to check</param>
        /// <returns>True if the user has pending request</returns>
        public static bool PendingRequest(int id)
        {
            var pending = false;

            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return pending;

            const string query = "SELECT request_status FROM requests WHERE id_user = @id";

            var command = new MySqlCommand(query, Conn);
            command.Prepare();
            command.Parameters.AddWithValue("@id", id);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader[0].ToString() == "waiting")
                    pending = true;
            }

            return pending;
        }

        /// <summary>
        /// Delete request with the specified id
        /// </summary>
        /// <param name="id">Id of the request to delete</param>
        /// <returns>True if the request was deleted</returns>
        public static bool DeleteRequest(int id)
        {
            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return false;

            const string query = "DELETE FROM requests WHERE id_request = @id";

            var command = new MySqlCommand(query, Conn);
            command.Prepare();
            command.Parameters.AddWithValue("@id", id);

            return command.ExecuteNonQuery() > 0;
        }

        public static bool DeleteDonation(int id)
        {
            if (!Connect(Settings.Default.server, Settings.Default.db_user,
                Settings.Default.db_pwd, Settings.Default.db_name)) return false;

            const string query = "DELETE FROM donations WHERE id_donation = @id";

            var command = new MySqlCommand(query, Conn);
            command.Prepare();
            command.Parameters.AddWithValue("@id", id);

            return command.ExecuteNonQuery() > 0;
        }

        #endregion Methods
    }
}