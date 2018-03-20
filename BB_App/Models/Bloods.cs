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
    class Bloods
    {

        /// <summary>
        /// Represents a blood object with group and units.
        /// </summary>
        public class Blood
        {
            public string BloodGroup { get; set; }
            public int BloodUnits { get; set; }
        }

        #region Fields

        public static List<Blood> BloodsList = new List<Blood>();

        #endregion

        #region Methods

        /// <summary>
        /// Load bloodgroups with units from the database.
        /// </summary>
        private static void loadBloods()
        {

            SqlConnection.Disconnect();

            if (SqlConnection.Connect(param.server, param.db_user, param.db_password, param.db_name))
            {
                if (Exist())
                {
                    string query = "SELECT AP, AM, BP, BM, ABP, ABM, OP, OM FROM blood_bank WHERE ref_hospital = '" + param.hospital + "'";
                    MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);
                    MySqlDataReader reader = command.ExecuteReader();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        reader.Read();

                        Blood blood = new Blood() { BloodGroup = reader.GetName(i), BloodUnits = reader.GetInt32(i) };
                        BloodsList.Add(blood);
                    }

                }
            }

        }

        /// <summary>
        /// Update units of bloodgroups to the database based on the values of the current list.
        /// </summary>
        public static void updateValues()
        {

            SqlConnection.Disconnect();

            if (SqlConnection.Connect(param.server, param.db_user, param.db_password, param.db_name))
            {
                string query = "UPDATE blood_bank SET AP = @ap, AM = @am, BP = @bp, BM = @bm, ABP = @abp, ABM = @abm, OP = @op, OM = @om, Total = @total";
                MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);

                command.Prepare();

                foreach (Blood blood in BloodsList)
                {
                    int unit = blood.BloodUnits;
                    command.Parameters.Add(unit);
                }

                command.Parameters.AddWithValue("@total", getTotal(BloodsList));

                command.ExecuteNonQuery();
            }

        }

        /// <summary>
        /// Populates the blood_bank table with null values from the current hospital.
        /// </summary>
        public static void initializeBloods()
        {

            SqlConnection.Disconnect();

            if (SqlConnection.Connect(param.server, param.db_user, param.db_password, param.db_name))
            {
                string query = "INSERT INTO blood_bank VALUES (@hospital, 0, 0, 0, 0, 0, 0, 0, 0, 0);";
                MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);

                command.Prepare();
                command.Parameters.AddWithValue("@hospital", param.hospital);

                command.ExecuteNonQuery();
            }

            loadBloods();

        }

        #endregion

        #region Functions

        /// <summary>
        /// Verify if the database contains blood informations of the current hospital.
        /// </summary>
        /// <returns>True if exist and false if not</returns>
        public static bool Exist()
        {
            bool _exist = false;

            SqlConnection.Disconnect();

            if (SqlConnection.Connect(param.server, param.db_user, param.db_password, param.db_name))
            {
                string query = "SELECT * FROM blood_bank WHERE ref_hospital = '" + param.hospital + "'";
                MySqlCommand command = new MySqlCommand(query, SqlConnection.conn);
                MySqlDataReader reader = command.ExecuteReader();

                _exist = reader.HasRows;

                reader.Close();
            }

            return _exist;

        }

        /// <summary>
        /// Calculates the sum of all elements from a blood list.
        /// </summary>
        /// <param name="list">The blood list to calculates the sum of items.</param>
        /// <returns>An integer representing the sum of all items</returns>
        private static int getTotal(List<Blood> list)
        {
            int sum = 0;

            foreach (Blood blood in list)
                sum += blood.BloodUnits;

            return sum;
        }

        #endregion

    }
}
