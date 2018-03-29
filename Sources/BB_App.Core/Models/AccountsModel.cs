using System.ComponentModel;
using BB_App.Helpers;
using MySql.Data.MySqlClient;
using static BB_App.Core.Models.SqlConnection;
using static BB_App.Core.Models.Consts;
using static BB_App.Core.Properties.Settings;
using static BB_App.Helpers.AccountsHelpers;
using static BB_App.Helpers.StringHelpers;

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
			Default.account_type = ParseAccountType(type);
			Default.Save();
			Default.Reload();
		}

	    public static void SetCurrentUser(string user)
	    {
	        Default.current_user = Capitalize(user).Trim(' ');
	        Default.Save();
	        Default.Reload();
        }

	    public static string WhoIsConnected() => Default.current_user;

	    /// <summary>
	    /// Determines if the user with the username given in parameters is administrator 
	    /// </summary>
	    /// <param name="username">Username of the user to check</param>
	    /// <returns>True if the user is an administrator</returns>
	    public static bool IsAdmin(string username)
	    {
	        var isAdmin = false;

	        if (!Connect(Server, DbUser, DbPassword, DbName)) return false;

	        const string query = "SELECT account_type FROM accounts WHERE username = @user";
            
            var command = new MySqlCommand(query, Conn);
            command.Prepare();
	        command.Parameters.AddWithValue("@user", username.ToLower());
	        var reader = command.ExecuteReader();

            if (reader.HasRows)
                while (reader.Read())
                    isAdmin = reader[0].ToString() == "admin";

	        return isAdmin;
	    }

    }
}
