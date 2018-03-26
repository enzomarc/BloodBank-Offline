using BB_App.Core.Properties;

namespace BB_App.Core.Models
{
    /// <summary>
    ///     Provides constants
    /// </summary>
    internal static class Consts
    {
        // Database Connection Params
        internal static string Server = Settings.Default.server;
        internal static string DbUser = Settings.Default.db_user;
        internal static string DbPassword = Settings.Default.db_pwd;
        internal static string DbName = Settings.Default.db_name;

        // Common constants
        internal static string Hospital = Settings.Default.reference;
    }
}