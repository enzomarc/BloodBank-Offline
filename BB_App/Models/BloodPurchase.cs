using System;
using MySql.Data.MySqlClient;
using static BB_App.Models.Bloods;
using static BB_App.Models.Commons;
using static BB_App.Models.SqlConnection;
using static BB_App.Models.Consts;

namespace BB_App.Models
{
    public class BloodPurchase
    {
        public static void PurchaseBlood(string bloodGroup, DateTime date, int units, int price)
        {
            if (!Connect(Server, DbUser, DbPassword, DbName)) return;

            const string query = "INSERT INTO purchases (bloodgroup, date, units, price) VALUES (@bg, @dt, @un, @pr);";
            var query2 = "UPDATE blood_bank SET " + bloodGroup + " = @value WHERE ref_hospital = @hospital";

            var command = new MySqlCommand(query, Conn);
            var command2 = new MySqlCommand(query2, Conn);

            command.Prepare();
            command.Parameters.AddWithValue("@bg", bloodGroup);
            command.Parameters.AddWithValue("@dt", date);
            command.Parameters.AddWithValue("@un", units);
            command.Parameters.AddWithValue("@pr", price);

            command2.Prepare();
            command2.Parameters.AddWithValue("@bg", bloodGroup);
            command2.Parameters.AddWithValue("@value", getUnits(bloodGroup) + units);
            command2.Parameters.AddWithValue("@hospital", Hospital);

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();
        }
    }
}