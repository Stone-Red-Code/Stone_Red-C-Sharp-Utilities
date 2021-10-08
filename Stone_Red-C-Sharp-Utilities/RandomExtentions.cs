using System;
using System.Collections.Generic;
using System.Linq;

namespace Stone_Red_Utilities.RandomExtentions
{
    /// <summary>
    /// <see cref="Random"/> Extentions
    /// </summary>
    public static class RandomExt
    {
        /// <summary>
        /// Returns an random item from the specified <paramref name="collection"/> using the <see cref="Random"/> class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="random"></param>
        /// <param name="collection"></param>
        /// <returns>Returns a random item from the specified <paramref name="collection"/></returns>
        /// <exception cref="ArgumentNullException"><paramref name="collection" /> is <see langword="null" /></exception>
        public static T NextItem<T>(this Random random, IEnumerable<T> collection)
        {
            if (collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            T[] items = collection.ToArray();
            return items[random.Next(items.Length)];
        }

        /// <summary>
        /// Returns a random <see cref="bool"/> using the <see cref="Random" /> class
        /// </summary>
        /// <param name="random"></param>
        /// <returns>Returns <see langword="true" /> or <see langword="false"/></returns>
        /// <exception cref="ArgumentNullException"><paramref name="random" /> is <see langword="null" /></exception>
        public static bool NextBool(this Random random)
        {
            return random.Next(2) == 0;
        }

        /// <summary>
        /// Returns a random item from the specified <see cref="Enum"/> using the <see cref="Random" /> class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="random"></param>
        /// <returns></returns>
        public static T NextEnum<T>(this Random random) where T : Enum //Not the best solution but it works
        {
            Array arr = Enum.GetValues(typeof(T));
            return (T)arr.GetValue(random.Next(arr.Length));
        }
    }
}