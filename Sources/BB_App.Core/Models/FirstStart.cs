using BB_App.Core.Properties;

namespace BB_App.Core.Models
{
    /// <summary>
    ///     Different operations to execute whe the application started for the first time.
    /// </summary>
    public class FirstStart
    {
        public FirstStart()
        {
            if (Settings.Default.first_start)
            {
                // Blood.initializeBank();
            }

            Settings.Default.first_start = false;
            Settings.Default.Save();
        }
    }
}