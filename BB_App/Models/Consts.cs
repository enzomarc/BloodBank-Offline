namespace BB_App.Models
{
    /// <summary>
    /// Provides constants
    /// </summary>
    internal static class Consts
    {
        // Database Connection Params
        internal static string Server = Properties.Settings.Default.server;
        internal static string DbUser = Properties.Settings.Default.db_user;
        internal static string DbPassword = Properties.Settings.Default.db_pwd;
        internal static string DbName = Properties.Settings.Default.db_name;

        // Common constants
        internal static string Hospital = Properties.Settings.Default.reference;
    }
}
