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

        public static string UniqueId(int size = 8)
        {
            var id = "";
            var r = new Random();
            string[] chars = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            for (var i = 0; i < size; i++)
            {
                id += chars[r.Next(0, chars.Length)];
            }

            return id;
        }

    }
}
