using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace BB_App.Core.Models
{
    public class BloodSale
    {
        #region Fields

        private static MySqlDataAdapter Adapter;
        private static readonly DataSet Datas = new DataSet();

        #endregion

        #region Methods

        public static void saleBlood(string bloodgroup, DateTime date, int units, int price)
        {
            if (!SqlConnection.Connect(Consts.Server, Consts.DbUser, Consts.DbPassword, Consts.DbName)) return;

            const string query =
                "INSERT INTO sales (ref_hospital, bloodgroup, date, units, price) VALUES (@ref, @bg, @dt, @un, @pr);";
            var query2 = "UPDATE blood_bank SET " + bloodgroup + " = @value WHERE ref_hospital = @hospital";

            var command = new MySqlCommand(query, SqlConnection.Conn);
            var command2 = new MySqlCommand(query2, SqlConnection.Conn);

            command.Prepare();
            command.Parameters.AddWithValue("@ref", Consts.Hospital);
            command.Parameters.AddWithValue("@bg", bloodgroup);
            command.Parameters.AddWithValue("@dt", date);
            command.Parameters.AddWithValue("@un", units);
            command.Parameters.AddWithValue("@pr", price);

            command2.Prepare();
            command2.Parameters.AddWithValue("@bg", bloodgroup);
            command2.Parameters.AddWithValue("@value", Bloods.GetUnits(bloodgroup) - units);
            command2.Parameters.AddWithValue("@hospital", Consts.Hospital);

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
        }

        public static DataSet LoadReports()
        {
            if (!SqlConnection.Connect(Consts.Server, Consts.DbUser, Consts.DbPassword, Consts.DbName)) return Datas;

            var query = "SELECT id, bloodgroup, date, units, price FROM sales WHERE ref_hospital = '" +
                        Consts.Hospital + "'";
            Adapter = new MySqlDataAdapter(query, SqlConnection.Conn);

            Datas.Clear();
            Adapter.Fill(Datas, "sales");

            return Datas;
        }

        #endregion Methods
    }
}