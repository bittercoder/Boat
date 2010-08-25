using System;
using System.Collections.Generic;

namespace Boat
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> e, Action<T> a)
        {
            foreach (T item in e)
            {
                a(item);
            }
        }
    }
}
