using System;
using System.Data;
using MySql.Data.MySqlClient;
using static BB_App.Models.Consts;
using static BB_App.Models.Bloods;
using static BB_App.Models.SqlConnection;

namespace BB_App.Models
{
    public class BloodSale
    {

        #region Fields

        private static MySqlDataAdapter Adapter;
        private static DataSet Datas = new DataSet();

        #endregion

        #region Methods

        public static void saleBlood(string bloodgroup, DateTime date, int units, int price)
        {
            if (!Connect(Server, DbUser, DbPassword, DbName)) return;

            const string query = "INSERT INTO sales (ref_hospital, bloodgroup, date, units, price) VALUES (@ref, @bg, @dt, @un, @pr);";
            var query2 = "UPDATE blood_bank SET " + bloodgroup + " = @value WHERE ref_hospital = @hospital";

            var command = new MySqlCommand(query, Conn);
            var command2 = new MySqlCommand(query2, Conn);

            command.Prepare();
            command.Parameters.AddWithValue("@ref", Hospital);
            command.Parameters.AddWithValue("@bg", bloodgroup);
            command.Parameters.AddWithValue("@dt", date);
            command.Parameters.AddWithValue("@un", units);
            command.Parameters.AddWithValue("@pr", price);

            command2.Prepare();
            command2.Parameters.AddWithValue("@bg", bloodgroup);
            command2.Parameters.AddWithValue("@value", getUnits(bloodgroup) - units);
            command2.Parameters.AddWithValue("@hospital", Hospital);

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
        }

        public static DataSet loadReports()
        {
            if (!Connect(Server, DbUser, DbPassword, DbName)) return Datas;

            var query = "SELECT id, bloodgroup, date, units, price FROM sales WHERE ref_hospital = '" + Hospital + "'";
            Adapter = new MySqlDataAdapter(query, Conn);

            Datas.Clear();
            Adapter.Fill(Datas, "sales");

            return Datas;
        }

        #endregion Methods

    }
}
