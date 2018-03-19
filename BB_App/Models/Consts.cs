using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BB_App.Models
{
    /// <summary>
    /// Provides constants
    /// </summary>
    internal static class Consts
    {
        // Database Connection Params
        internal static string server = Properties.Settings.Default.server;
        internal static string db_user = Properties.Settings.Default.db_user;
        internal static string db_password = Properties.Settings.Default.db_pwd;
        internal static string db_name = Properties.Settings.Default.db_name;

        // Common constants
        internal static string hospital = Properties.Settings.Default.reference;
    }
}
