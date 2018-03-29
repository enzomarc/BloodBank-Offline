using System;

namespace BB_App.Helpers
{
    public class StringHelpers
    {

        /// <summary>
        /// Capitalize string
        /// </summary>
        /// <param name="str"></param>
        /// <returns>A capitalize representation of the string given in parameters</returns>
        public static string Capitalize(string str)
        {
            var capitalized = string.Empty;

            if (str.Split(' ').Length > 0)
            {
                foreach (var word in str.Split(' '))
                {
                    capitalized += word[0].ToString().ToUpper() + word.Remove(0, 1) + " ";
                }
            }
            else
                capitalized = str[0].ToString().ToUpper() + str.Substring(1, str.Length);

            return capitalized;
        }

    }
}
