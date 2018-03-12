using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MaranAtha
{
    public static class StringExtensions
    {
        public static string FullTrim(this string str)
        {
            return Regex.Replace(str.TrimStart().TrimEnd().Trim(), @"\s+", " ");
        }

        public static bool IsNullOrEmptyOrWhiteSpace(this string str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }

        public static string ToCommaSeperatedString(this IEnumerable<string> list)
        {
            return string.Join(", ", list);
        }

        public static string ToCommaAndSeperatedString(this IEnumerable<string> enumerable)
        {
            var list = enumerable as IList<string> ?? enumerable.ToList();
            if (!list.Any())
                return string.Empty;
            switch (list.Count)
            {
                case 1:
                    return list[0];
                case 2:
                    return $"{list[0]} and {list[1]}";
                default:
                    var result = new StringBuilder();
                    for (var i = 0; i < list.Count - 1; i++)
                        result.Append($"{list[i]}, ");
                    result.Append($"and {list[list.Count - 1]}");
                    return result.ToString();
            }
        }

        public static DateTime ToDateTimeFromArabicFormattedDate(this string str)
        {
            var dateParts = str.Split(' ');
            int monthNumbre;
            switch (dateParts[1])
            {
                case "يناير":
                    monthNumbre = 1;
                    break;
                case "فبراير":
                    monthNumbre = 2;
                    break;
                case "مارس":
                    monthNumbre = 3;
                    break;
                case "أبريل":
                    monthNumbre = 4;
                    break;
                case "مايو":
                    monthNumbre = 5;
                    break;
                case "يونيو":
                    monthNumbre = 6;
                    break;
                case "يوليه":
                    monthNumbre = 7;
                    break;
                case "أغسطس":
                    monthNumbre = 8;
                    break;
                case "سبتمبر":
                    monthNumbre = 9;
                    break;
                case "أكتوبر":
                    monthNumbre = 10;
                    break;
                case "نوفمبر":
                    monthNumbre = 11;
                    break;
                case "ديسمبر":
                    monthNumbre = 12;
                    break;
                default:
                    monthNumbre = 0;
                    break;
            }
            return new DateTime(int.Parse(dateParts[2]), monthNumbre, int.Parse(dateParts[0]));
        }
    }
}