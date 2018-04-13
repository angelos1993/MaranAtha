using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaranAtha
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Concatenates the elements of an IEnumerable object, using comma (,) as a separator but 'and' before the last element.
        /// </summary>
        /// <param name="enumerableStrings">The list that contains the elements to be concatenated</param>
        /// <returns>A string that consists of the elements of values delimited by the comma and 'and' (before the last element). If the passed parameter is an empty list, the method returns System.String.Empty.</returns>
        public static string ToCommaThenAndString(this IEnumerable<string> enumerableStrings)
        {
            return enumerableStrings.ToList().ToCommaThenAndString();
        }

        /// <summary>
        /// Concatenates the elements of an array object, using comma (,) as a separator but 'and' before the last element.
        /// </summary>
        /// <param name="arrayStrings">The array that contains the elements to be concatenated</param>
        /// <returns>A string that consists of the elements of values delimited by the comma and 'and' (before the last element). If the passed parameter is an empty array, the method returns System.String.Empty.</returns>
        public static string ToCommaThenAndString(this string[] arrayStrings)
        {
            return arrayStrings.ToList().ToCommaThenAndString();
        }

        /// <summary>
        /// Concatenates the elements of a List object, using comma (,) as a separator but 'and' before the last element.
        /// </summary>
        /// <param name="listStrings">The list that contains the elements to be concatenated</param>
        /// <returns>A string that consists of the elements of values delimited by the comma and 'and' (before the last element). If the passed parameter is an empty list, the method returns System.String.Empty.</returns>
        public static string ToCommaThenAndString(this List<string> listStrings)
        {
            if (!listStrings.Any())
                return string.Empty;
            switch (listStrings.Count)
            {
                case 1:
                    return listStrings[0];
                case 2:
                    return $"{listStrings[0]} and {listStrings[1]}";
                default:
                    var resultStringBuilder = new StringBuilder();
                    for (var i = 0; i < listStrings.Count - 1; i++)
                        resultStringBuilder.Append($"{listStrings[i]}, ");
                    resultStringBuilder.Append($"and {listStrings[listStrings.Count - 1]}");
                    return resultStringBuilder.ToString();
            }
        }

        /// <summary>
        /// Concatenates the elements of a List object, using comma (,) as a separator then space after each comma.
        /// </summary>
        /// <param name="enumerableStrings">The list that contains the elements to be concatenated</param>
        /// <returns>A string that consists of the elements of values delimited by the comma and space. If the passed parameter is an empty list, the method returns System.String.Empty.</returns>
        public static string ToCommaSeperatedString(this IEnumerable<string> enumerableStrings)
        {
            return enumerableStrings.ToList().ToCommaSeperatedString();
        }

        /// <summary>
        /// Concatenates the elements of an array object, using comma (,) as a separator then space after each comma.
        /// </summary>
        /// <param name="arrayStrings">The array that contains the elements to be concatenated</param>
        /// <returns>A string that consists of the elements of values delimited by the comma and space. If the passed parameter is an empty array, the method returns System.String.Empty.</returns>
        public static string ToCommaSeperatedString(this string[] arrayStrings)
        {
            return arrayStrings.ToList().ToCommaSeperatedString();
        }

        /// <summary>
        /// Concatenates the elements of a list object, using comma (,) as a separator then space after each comma.
        /// </summary>
        /// <param name="listStrings">The list that contains the elements to be concatenated</param>
        /// <returns>A string that consists of the elements of values delimited by the comma and space. If the passed parameter is an empty list, the method returns System.String.Empty.</returns>
        public static string ToCommaSeperatedString(this List<string> listStrings)
        {
            return listStrings.ToSeperatedString(", ");
        }

        /// <summary>
        /// Concatenates the elements of a list object, using the specified separator between each member.
        /// </summary>
        /// <param name="enumerableStrings">The list that contains the elements to be concatenated</param>
        /// <param name="separator">The string to use as a separator.</param>
        /// <returns>A string that consists of the elements of values delimited by the comma and space. If the passed parameter is an empty list, the method returns System.String.Empty.</returns>
        public static string ToSeperatedString(this IEnumerable<string> enumerableStrings, string separator)
        {
            return enumerableStrings.ToList().ToSeperatedString(separator);
        }

        /// <summary>
        /// Concatenates the elements of an array object, using the specified separator between each member.
        /// </summary>
        /// <param name="arrayStrings">The array that contains the elements to be concatenated</param>
        /// <param name="separator">The string to use as a separator.</param>
        /// <returns>A string that consists of the elements of values delimited by the comma and space. If the passed parameter is an empty array, the method returns System.String.Empty.</returns>
        public static string ToSeperatedString(this string[] arrayStrings, string separator)
        {
            return arrayStrings.ToList().ToSeperatedString(separator);
        }

        /// <summary>
        /// Concatenates the elements of a list object, using the specified separator between each member.
        /// </summary>
        /// <param name="listStrings">The list that contains the elements to be concatenated</param>
        /// <param name="separator">The string to use as a separator.</param>
        /// <returns>A string that consists of the elements of values delimited by the comma and space. If the passed parameter is an empty list, the method returns System.String.Empty.</returns>
        public static string ToSeperatedString(this List<string> listStrings, string separator)
        {
            return string.Join(separator, listStrings);
        }
    }
}