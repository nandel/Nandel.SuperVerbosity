using System.Collections.Generic;
using System.Linq;

namespace Nandel.SuperVerbosity
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Add an item to the list if no other equal item exists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="item"></param>
        public static void AddIfNotExists<T>(this ICollection<T> collection, T item)
        {
            if (!collection.Any(x => x.Equals(item))) 
            {
                collection.Add(item);
            }
        }
    }
}
