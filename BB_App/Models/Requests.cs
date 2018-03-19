using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

/* =====================================================
 * Class Name : Requests
 * Description : Performing CRUD on requests over the database.
 * Author : Marc Enzo
 * At : 16/03/2018
 * ===================================================== */

namespace BB_App.Models
{
    /// <summary>
    /// Requests Management Class for the database.
    /// </summary>
    class Requests
    {

        #region Fields

        
        public static MySqlDataAdapter adapter;
        public static DataSet datas = new DataSet();

        #endregion

        /// <summary>
        /// Represents a set of datas based on request available in the database.
        /// </summary>
        public class Request
        {

            #region Fields

            private int fromId, request_id, request_user, unit;
            private string hospital_ref, request_status;
            private DateTime request_date, date_limit;

            #endregion

            #region Constructors

            /// <summary>
            /// Clone of the request object available in the database
            /// </summary>
            /// <param name="req_user">id of the user who is making request</param>
            /// <param name="hospital">hospital reference from where the request is maded</param>
            /// <param name="req_date">the day where the request was made</param>
            /// <param name="exp_date">the day the request will expires</param>
            /// <param name="qty">the number units of blood the user needs</param>
            /// <param name="status">status message of the request (waiting, cancelled, done)</param>
            public Request(int req_user, string hospital, DateTime req_date, DateTime exp_date, int qty, string status)
            {
                request_user = req_user;
                unit = qty;
                hospital_ref = hospital;
                request_date = req_date;
                date_limit = exp_date;
                request_status = status;
            }

            /// <summary>
            /// Clone of the request object available in the database.
            /// </summary>
            /// <param name="id">id of the blood request to load from the database</param>
            public Request(int id = 0)
            {
                fromId = id;
                loadFrom();
            }

            #endregion

            #region Methods

            /// <summary>
            /// Load request from the database.
            /// </summary>
            /// <param name="id">id of the request to load</param>
            public void loadFrom(int id = 0)
            {

                try
                {

                    if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
                    {

                        string query;

                        if (id != 0)
                            query = "SELECT * FROM requests WHERE id_request = " + id;
                        else
                            query = "SELECT * FROM requests WHERE id_request = " + fromId;

                        MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);
                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            
                            while (reader.Read())
                            {
                                this.request_id = Convert.ToInt32(reader[0]);
                                this.request_user = Convert.ToInt32(reader[1]);
                                this.hospital_ref = Convert.ToString(reader[2]);
                                this.request_date = Convert.ToDateTime(reader[3]);
                                this.date_limit = Convert.ToDateTime(reader[4]);
                                this.unit = Convert.ToInt32(reader[5]);
                                this.request_status = Convert.ToString(reader[6]);
                            }

                            reader.Close();

                        }

                    }

                }
                catch
                {
                    throw new NotImplementedException();
                }

            }

            #endregion

            #region Properties

            /// <summary>
            /// ID of the request.
            /// </summary>
            public int RequestID
            {
                get { return request_id; }
                set { request_id = value; }
            }

            /// <summary>
            /// ID of the user who makes request.
            /// </summary>
            public int RequestUser
            {
                get { return request_user; }
                set { request_user = value; }
            }

            /// <summary>
            /// Number units of blood for the request.
            /// </summary>
            public int Unit
            {
                get { return unit; }
                set { unit = value; }
            }

            /// <summary>
            /// Reference of the hospital where the request is passed.
            /// </summary>
            public string HospitalReference
            {
                get { return hospital_ref; }
                set { hospital_ref = value; }
            }

            /// <summary>
            /// Request status (waiting, cancelled, done).
            /// </summary>
            public string RequestStatus
            {
                get { return request_status; }
                set { request_status = value; }
            }

            /// <summary>
            /// Request initialization date.
            /// </summary>
            public DateTime RequestDate
            {
                get { return request_date; }
                set { request_date = value; }
            }

            /// <summary>
            /// Request expiration date.
            /// </summary>
            public DateTime ExpirationDate
            {
                get { return date_limit; }
                set { date_limit = value; }
            }

            #endregion

        }

        #region Methods

        /// <summary>
        /// Load requests from the database based on the hospital reference.
        /// </summary>
        /// <returns>A dataset that represents a clone of datas from the database.</returns>
        public static DataSet loadRequests()
        {
            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                string query = "SELECT * FROM requests WHERE ref_hospital = '" + Properties.Settings.Default.reference + "'";
                adapter = new MySqlDataAdapter(query, SqlConnection.conn);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

                datas.Clear();
                adapter.Fill(datas, "requests");
            }

            return datas;
        }

        /// <summary>
        /// Insert request tnto the database.
        /// </summary>
        /// <param name="req">Request to save</param>
        /// <returns>Boolean that represent the insert result.</returns>
        public static bool saveRequest(Request req)
        {
            // Variaable who checks if the request was saved
            bool saved = false;

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {

                string date = req.RequestDate.Year.ToString() + "-" + req.RequestDate.Month.ToString() + "-" + req.RequestDate.Day.ToString();
                string expDate = req.ExpirationDate.Year.ToString() + "-" + req.ExpirationDate.Month.ToString() + "-" + req.ExpirationDate.Day.ToString();

                string query = "INSERT INTO requests(id_user, ref_hospital, request_date, limit_date, unit, request_status) VALUES (@id, @ref, @date, @exp_date, @qty, @status);";

                MySqlCommand cmd = new MySqlCommand(query, SqlConnection.conn);
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@id", req.RequestUser);
                cmd.Parameters.AddWithValue("@ref", Properties.Settings.Default.reference);
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

            }

            return saved;
        }

        /// <summary>
        /// Change the user who makes the request.
        /// </summary>
        /// <param name="request">id of the request to changes the user</param>
        /// <param name="id">id of the new user</param>
        /// <returns>Boolean that represents the update result.</returns>
        public static bool changeUser(int request, int id)
        {
            bool updated = false;

            if (SqlConnection.Connect(Properties.Settings.Default.server, Properties.Settings.Default.db_user, Properties.Settings.Default.db_pwd, Properties.Settings.Default.db_name))
            {
                string query = "UPDATE requests SET id_user = " + id + " WHERE id_request = " + request + ";";

                MySqlCommand cmd = new MySqlCommand(query, SqlConnection.conn);

                cmd.ExecuteNonQuery();
                updated = true;
            }

            return updated;
        }

        #endregion

    }
}
