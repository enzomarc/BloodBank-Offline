using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BB_App.Helpers
{
	public class AccountsHelpers
	{

		public static AccountType ParseAccountType(string fromStr)
		{

			fromStr = fromStr.ToLower();
			AccountType type;

			switch (fromStr)
			{
				case "admin":
					type = AccountType.Administrator;
					break;
				case "analyst":
					type = AccountType.Analyst;
					break;
				case "default":
					type = AccountType.Default;
					break;
				default:
					type = AccountType.Default;
					break;
			}

			return type;
		}

		public static string ParseAccountType(AccountType fromType)
		{
			var type = string.Empty;

			switch (fromType)
			{
				case AccountType.Administrator:
					type = "admin";
					break;
				case AccountType.Analyst:
					type = "analyst";
					break;
				case AccountType.Default:
					type = "default";
					break;
				default:
					type = "default";
					break;
			}

			return type;
		}

	}
}
