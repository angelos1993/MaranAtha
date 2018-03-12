using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaranAtha
{
    public static class CollectionExtensions
    {
        public static string ToCommaThenAndString(this IEnumerable<string> enumerableStrings)
        {
            return enumerableStrings.ToList().ToCommaThenAndString();
        }

        public static string ToCommaThenAndString(this string[] arrayStrings)
        {
            return arrayStrings.ToList().ToCommaThenAndString();
        }

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
                    return listStrings.ToString();
            }
        }

        public static string ToCommaSeperatedString(this IEnumerable<string> enumerableStrings)
        {
            return enumerableStrings.ToList().ToCommaSeperatedString();
        }

        public static string ToCommaSeperatedString(this string[] arrayStrings)
        {
            return arrayStrings.ToList().ToCommaSeperatedString();
        }

        public static string ToCommaSeperatedString(this List<string> listStrings)
        {
            return listStrings.ToSeperatedString(", ");
        }

        public static string ToSeperatedString(this IEnumerable<string> enumerableStrings, string separator)
        {
            return enumerableStrings.ToList().ToSeperatedString(separator);
        }

        public static string ToSeperatedString(this string[] arrayStrings, string separator)
        {
            return arrayStrings.ToList().ToSeperatedString(separator);
        }

        public static string ToSeperatedString(this List<string> listStrings, string separator)
        {
            return string.Join(separator, listStrings);
        }
    }
}