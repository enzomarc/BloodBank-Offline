namespace BB_App.Models
{
    internal static class Commons
    {
        #region Methods

        public static string Format(string bloodgroup)
        {
            var formatted = string.Empty;

            bloodgroup = bloodgroup.ToLower();

            switch (bloodgroup)
            {
                case "ap":
                    formatted = "A+";
                    break;

                case "am":
                    formatted = "A-";
                    break;

                case "bp":
                    formatted = "B+";
                    break;

                case "bm":
                    formatted = "B-";
                    break;

                case "abp":
                    formatted = "AB+";
                    break;

                case "abm":
                    formatted = "AB-";
                    break;

                case "op":
                    formatted = "O+";
                    break;

                case "om":
                    formatted = "O-";
                    break;
            }

            return formatted;
        }

        #endregion Methods
    }
}