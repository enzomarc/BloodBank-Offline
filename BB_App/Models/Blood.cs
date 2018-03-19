using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using BB_App.Models;
using param =  BB_App.Models.Consts;

/* =============================================================
* Class Name : Blood
* Description : Performs CRUD on blood over the database.
* By : Marc Enzo
* At : 17/03/1018
* ============================================================= */

namespace BB_App.Models
{
    /// <summary>
    /// Represents the blood bank from the database.
    /// </summary>
    class Blood
    {

        #region Fields

        /// <summary>
        /// Blood item with bloodgroup and unit.
        /// </summary>
        public struct blood
        {
            public string bloodgroup;
            public int unit;
        }

        // List of all bloodgroup
        private static List<blood> bloodgroups;

        #endregion

        #region Constructors

        /// <summary>
        /// Represents the blood bank from the database.
        /// </summary>
        public Blood()
        {
            bloodgroups = new List<blood>(8);
            loadBloods();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Populate the bloodbank table with null values (Initialize or Reset).
        /// </summary>
        public static void initializeBank()
        {

            if (!Exist())
            {
                if (SqlConnection.Connect(param.server, param.db_user, param.db_password, param.db_name))
                {
                    string query = "INSERT INTO blood_bank VALUES ('" + param.hospital + "', 0, 0, 0, 0, 0, 0, 0, 0, 0);";
                    MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);

                    command.ExecuteNonQuery();
                }
            }

        }

        /// <summary>
        /// Populate bloodgroups list with data loaded from the database.
        /// </summary>
        public static void loadBloods()
        {

            if (SqlConnection.Connect(param.server, param.db_user, param.db_password, param.db_name))
            {

                string query = "SELECT AP, AM, BP, BM, ABP, ABM, OP, OM FROM blood_bank WHERE ref_hospital = '" + param.hospital + "';";
                MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    // blood structure to add to the bloodgroups list
                    blood bl;

                    int i = 0;

                    while (reader.Read())
                    {
                        bl.bloodgroup = reader.GetName(i);
                        bl.unit = Convert.ToInt32(reader[i]);

                        bloodgroups.Add(bl);
                        i++;
                    }

                }

            }

        }

        /// <summary>
        /// Update bloods units values in the database based on the current list.
        /// </summary>
        public static void updateValues()
        {

            if (SqlConnection.Connect(param.server, param.db_user, param.db_password, param.db_name))
            {
                
                foreach (blood _blood in bloodgroups)
                {
                    string query = "UPDATE blood_bank SET " + _blood.bloodgroup + " = " + _blood.unit + " WHERE ref_hospital = '" + param.hospital + "';";
                    MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);

                    command.ExecuteNonQuery();
                }

            }

        }

        /// <summary>
        /// Calculates total units of blood available from bloodgroups list and update the database.
        /// </summary>
        public static void updateTotal()
        {
            
            if (bloodgroups.Count > 0)
            {
                int total = 0;

                foreach (blood _blood in bloodgroups)
                    total += _blood.unit;

                if (SqlConnection.Connect(param.server, param.db_user, param.db_password, param.db_name))
                {
                    string query = "UPDATE blood_bank SET Total = " + total + " WHERE ref_hospital = '" + param.hospital + "';";
                    MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);

                    command.ExecuteNonQuery();
                }
            }

        }

        #endregion

        #region Functions

        /// <summary>
        /// Determines if the blood_bank table doesn't contains hospital blood informations.
        /// </summary>
        /// <returns>A boolean that indicates if the blood_bank doesn't contains hospital informations</returns>
        public static bool Exist()
        {
            bool _exist = false;

            if (SqlConnection.Connect(param.server, param.db_user, param.db_password, param.db_name))
            {
                string query = "SELECT * FROM blood_bank WHERE ref_hospital = '" + param.hospital + "';";
                MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);
                MySqlDataReader reader = command.ExecuteReader();

                _exist = reader.HasRows;
            }

            return _exist;
        }

        #endregion

    }
}
