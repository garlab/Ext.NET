using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ext.NET
{
    /// <summary>
    /// Contain every extensions for Integer.
    /// </summary>
    public static class IntegerExtension
    {
        /// <summary>
        /// Repeat an action n times.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="action">Action applied on each element from the source</param>
        public static void Times(this int n, Action<int> action)
        {
            if (action == null) throw new ArgumentNullException("action");

            for (int i = 0; i < n; ++i)
            {
                action(i);
            }
        }

        /// <summary>
        /// Generate a range from "n" to "to".
        /// </summary>
        /// <param name="n"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public static IEnumerable<int> To(this int n, int to)
        {
            if (n == to)
            {
                yield return n;
            }
            else if (to > n)
            {
                for (int i = n; i < to; ++i)
                    yield return i;
            }
            else
            {
                for (int i = n; i > to; --i)
                    yield return i;
            }
        }
    }
}
