using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ext.NET
{
    public static class IntegerExtension
    {
        public static void Times(this int n, Action<int> action)
        {
            for (int i = 0; i < n; ++i)
            {
                action(i);
            }
        }

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
