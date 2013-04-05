using System;
using System.Collections.Generic;
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

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var random = new Random();
            return source.ShuffleIterator(random);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random random)
        {
            return source.ShuffleIterator(random);
        }

        private static IEnumerable<T> ShuffleIterator<T>(this IEnumerable<T> source, Random random)
        {
            var buffer = new List<T>(source);

            for (int i = 0; i < buffer.Count; ++i)
            {
                int j = random.Next(i, buffer.Count);
                yield return buffer[j];

                buffer[j] = buffer[i];
            }
        }
    }
}
