using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using param = BB_App.Models.Consts;

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
    internal class Bloods
    {
        /// <summary>dz
        /// Represents a blood object with group and units.
        /// </summary>
        public class Blood
        {
            public string BloodGroup { get; set; }

            public int BloodUnits { get; set; }
        }

        #region Fields

        public static List<Blood> BloodsList = new List<Blood>();

        #endregion Fields

        #region Constructors

        public Bloods()
        {
            if (Exist())
                LoadBloods();
            else
                InitializeBloods();
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Populates the blood_bank table with null values from the current hospital.
        /// </summary>
        public static void InitializeBloods()
        {
            SqlConnection.Disconnect();

            if (SqlConnection.Connect(param.Server, param.DbUser, param.DbPassword, param.DbName))
            {
                const string query = "INSERT INTO blood_bank VALUES (@hospital, 0, 0, 0, 0, 0, 0, 0, 0, 0);";
                var command = new MySqlCommand(query, SqlConnection.Conn);

                command.Prepare();
                command.Parameters.AddWithValue("@hospital", param.Hospital);

                command.ExecuteNonQuery();
            }

            LoadBloods();
        }

        /// <summary>
        /// Load bloodgroups with units from the database.
        /// </summary>
        public static void LoadBloods()
        {
            SqlConnection.Disconnect();

            if (!SqlConnection.Connect(param.Server, param.DbUser, param.DbPassword, param.DbName)) return;

            if (Exist())
            {
                var query = "SELECT AP, AM, BP, BM, ABP, ABM, OP, OM FROM blood_bank WHERE ref_hospital = '" + param.Hospital + "'";
                var command = new MySqlCommand(query, SqlConnection.Conn);
                var reader = command.ExecuteReader();

                for (var i = 0; i < reader.FieldCount; i++)
                {
                    reader.Read();

                    var blood = new Blood() { BloodGroup = reader.GetName(i), BloodUnits = reader.GetInt32(i) };
                    BloodsList.Add(blood);
                }

                reader.Close();
            }
            else
                InitializeBloods();
        }

        /// <summary>
        /// Update units of bloodgroups to the database based on the values of the current list.
        /// </summary>
        public static void UpdateValues()
        {
            SqlConnection.Disconnect();

            if (!SqlConnection.Connect(param.Server, param.DbUser, param.DbPassword, param.DbName)) return;

            const string query = "UPDATE blood_bank SET AP = @ap, AM = @am, BP = @bp, BM = @bm, ABP = @abp, ABM = @abm, OP = @op, OM = @om, Total = @total";
            var command = new MySqlCommand(query, SqlConnection.Conn);

            command.Prepare();

            foreach (var blood in BloodsList)
            {
                var unit = blood.BloodUnits;
                command.Parameters.Add(unit);
            }

            command.Parameters.AddWithValue("@total", GetTotal(BloodsList));

            command.ExecuteNonQuery();
        }
        #endregion Methods

        #region Functions

        /// <summary>
        /// Verify if the database contains blood informations of the current hospital.
        /// </summary>
        /// <returns>True if exist and false if not</returns>
        private static bool Exist()
        {
            SqlConnection.Disconnect();

            if (!SqlConnection.Connect(param.Server, param.DbUser, param.DbPassword, param.DbName)) return false;

            var query = "SELECT * FROM blood_bank WHERE ref_hospital = '" + param.Hospital + "'";
            var command = new MySqlCommand(query, SqlConnection.Conn);
            var reader = command.ExecuteReader();

            var exist = reader.HasRows;

            reader.Close();

            return exist;
        }

        /// <summary>
        /// Calculates the sum of all elements from a blood list.
        /// </summary>
        /// <param name="list">The blood list to calculates the sum of items.</param>
        /// <returns>An integer representing the sum of all items</returns>
        private static int GetTotal(IEnumerable<Blood> list)
        {
            return list.Sum(blood => blood.BloodUnits);
        }

        #endregion Functions
    }
}