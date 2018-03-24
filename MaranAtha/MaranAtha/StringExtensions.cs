using System.Text.RegularExpressions;

namespace MaranAtha
{
    public static class StringExtensions
    {
        /// <summary>
        /// Removes all leading and trailing white-space characters and converts the in-between multiple white-space into only one space from the current String object.
        /// </summary>
        /// <param name="str">The string to be trimmed</param>
        /// <returns>The trimmed string</returns>
        public static string FullTrim(this string str)
        {
            return Regex.Replace(str.TrimStart().TrimEnd().Trim(), @"\s+", " ");
        }

        /// <summary>
        /// Indicates whether a specified string is null, empty (System.String.Empty ("")), or consists only of white-space characters.
        /// </summary>
        /// <param name="str">The string to be tested.</param>
        /// <returns>true if the str parameter is null or empty (System.String.Empty ("")), or if str consists exclusively of white-space characters.</returns>
        public static bool IsNullOrEmptyOrWhiteSpace(this string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }
    }
}