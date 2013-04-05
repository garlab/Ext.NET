using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ext.NET
{
    public static class EnumerableExtension
    {
        public static void Each<T>(this IEnumerable<T> enumberable, Action<T> action)
        {
            foreach (var item in enumberable)
            {
                action(item);
            }
        }
    }
}
