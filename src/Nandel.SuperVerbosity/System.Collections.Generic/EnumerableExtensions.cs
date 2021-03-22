using System;
using System.Collections.Generic;
using System.Linq;

namespace Nandel.SuperVerbosity
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// !enumerable.Any() is too ugly to see
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable is null) throw new ArgumentNullException(nameof(enumerable));

            return !enumerable.Any();
        }

        /// <summary>
        /// "enumerable?.Any() != true" is even worse
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable?.Any() != true;
        }

        /// <summary>
        /// string.Join could do that for you
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string Join<T>(this IEnumerable<T> values, string separator)
        {
            return string.Join(separator, values);
        }
    }
}
