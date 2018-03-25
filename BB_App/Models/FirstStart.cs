namespace BB_App.Models
{
    /// <summary>
    /// Different operations to execute whe the application started for the first time.
    /// </summary>
    public class FirstStart
    {

        public FirstStart()
        {

            if (Properties.Settings.Default.first_start)
            {
                // Blood.initializeBank();
            }

            Properties.Settings.Default.first_start = false;
            Properties.Settings.Default.Save();
        }

    }
}
