﻿using System.Collections.Generic;
using System.Text;

namespace ReactiveServices.Extensions
{
    public static class EnumerableExtensions
    {
        public static string ToString<T>(this IEnumerable<T> items, string separator)
        {
            var result = new StringBuilder();
            foreach (var item in items)
            {
                result.Append(item);
                result.Append(separator);
            }
            result.Remove(result.Length - separator.Length, separator.Length);
            return result.ToString();
        }
    }
}
