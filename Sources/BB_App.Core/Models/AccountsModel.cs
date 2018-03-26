using BB_App.Helpers;
using MySql.Data.MySqlClient;
using static BB_App.Core.Models.SqlConnection;
using static BB_App.Core.Models.Consts;
using static BB_App.Helpers.AccountsHelpers;

namespace BB_App.Core.Models
{
	public class AccountsModel
	{

		public static string Login(string username, string password)
		{
			var type = string.Empty;

			if (!Connect(Server, DbUser, DbPassword, DbName)) return type;

			const string query =
				"SELECT username, password, account_type FROM accounts WHERE username = @user AND password = @pwd";

			var command = new MySqlCommand(query, Conn);
			command.Prepare();
			command.Parameters.AddWithValue("@user", username);
			command.Parameters.AddWithValue("@pwd", password);

			var reader = command.ExecuteReader();

			while (reader.Read())
				type = reader.GetString(2);

			return type;
		}

		public static void SetAccountType(AccountType type)
		{
			Properties.Settings.Default.account_type = ParseAccountType(type);
			Properties.Settings.Default.Save();
			Properties.Settings.Default.Reload();
		}

	}
}
