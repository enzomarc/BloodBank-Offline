namespace BB_App.Core.Models
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

        public static string Unformat(string bloodgroup)
        {
            var formatted = string.Empty;

            bloodgroup = bloodgroup.ToLower();

            switch (bloodgroup)
            {
                case "a+":
                    formatted = "AP";
                    break;
                case "a-":
                    formatted = "AM";
                    break;
                case "b+":
                    formatted = "BP";
                    break;
                case "b-":
                    formatted = "BM";
                    break;
                case "ab+":
                    formatted = "ABP";
                    break;
                case "ab-":
                    formatted = "ABM";
                    break;
                case "o+":
                    formatted = "OP";
                    break;
                case "o-":
                    formatted = "OM";
                    break;
            }

            return formatted;
        }

        public static int TotalPrice(int units, int price)
        {
            return units * price;
        }

        #endregion Methods
    }
}