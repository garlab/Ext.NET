using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Ext.NET
{
    public static class EnumerableExtension
    {
        public static void Each<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
        }

        public static IEnumerable<T> Grep<T>(this IEnumerable<T> enumerable, string pattern)
        {
            foreach (var item in enumerable)
            {
                if (item.ToString().Contains(pattern))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<T> EGrep<T>(this IEnumerable<T> enumerable, string pattern, RegexOptions option = RegexOptions.None)
        {
            var regex = new Regex(pattern, option);
            foreach (var item in enumerable)
            {
                if (regex.IsMatch(item.ToString()))
                {
                    yield return item;
                }
            }
        }
    }
}
