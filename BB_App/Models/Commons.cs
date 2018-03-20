using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BB_App.Models
{
    class Commons
    {

        #region Methods

        public static string Format(string bloodgroup)
        {
            string formatted = String.Empty;

            bloodgroup = bloodgroup.ToLower();

            if (bloodgroup == "ap")
                formatted = "A+";
            else if (bloodgroup == "am")
                formatted = "A-";
            else if (bloodgroup == "bp")
                formatted = "B+";
            else if (bloodgroup == "bm")
                formatted = "B-";
            else if (bloodgroup == "abp")
                formatted = "AB+";
            else if (bloodgroup == "abm")
                formatted = "AB-";
            else if (bloodgroup == "op")
                formatted = "O+";
            else if (bloodgroup == "om")
                formatted = "O-";

            return formatted;
        }

        #endregion

    }
}
