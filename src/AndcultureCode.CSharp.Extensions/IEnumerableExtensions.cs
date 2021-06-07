using System;
using System.Collections.Generic;
using System.Linq;
using AndcultureCode.CSharp.Extensions.Models;

namespace AndcultureCode.CSharp.Extensions
{
    /// <summary>
    /// IEnumerable extension methods
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Returns items in source collection that do not exist in second collection based on predicate
        /// </summary>
        public static IEnumerable<T> Except<T>(this IEnumerable<T> source, IEnumerable<T> second, Func<T, T, bool> predicate)
        {
            if (source.IsNullOrEmpty())
            {
                return Enumerable.Empty<T>();
            }

            if (second.IsNullOrEmpty())
            {
                return source;
            }

            return source.Except(second, new LambdaComparer<T>(predicate));
        }

        /// <summary>
        /// Determines if the source collection is non-null and has values
        /// </summary>
        public static bool HasValues<T>(this IEnumerable<T> source) => !source.IsNullOrEmpty();

        /// <summary>
        /// Determines if the source collection is non-null and has values
        /// </summary>
        public static bool HasValues<T>(this IEnumerable<T> source, Func<T, bool> predicate) =>
            !source.IsNullOrEmpty(predicate);

        /// <summary>
        /// Returns items in source collection that exist in second collection based on the predicate
        /// </summary>
        public static IEnumerable<T> Intersect<T>(this IEnumerable<T> source, IEnumerable<T> second, Func<T, T, bool> predicate)
        {
            if (source.IsNullOrEmpty() || second.IsNullOrEmpty())
            {
                return Enumerable.Empty<T>();
            }

            return source.Intersect(second, new LambdaComparer<T>(predicate));
        }

        /// <summary>
        /// Determines if the source list is empty
        /// </summary>
        public static bool IsEmpty<T>(this IEnumerable<T> source) => !source.Any();

        /// <summary>
        /// Determines if the source list is empty
        /// </summary>
        public static bool IsEmpty<T>(this IEnumerable<T> source, Func<T, bool> predicate) => !source.Any(predicate);

        /// <summary>
        /// Determines if the source list is null or empty
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source) => source == null || source.IsEmpty();

        /// <summary>
        /// Determines if the source list is null or empty
        /// </summary>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source, Func<T, bool> predicate) =>
            source == null || source.IsEmpty(predicate);

        /// <summary>
        /// Convenience method so joining strings reads better :)
        /// </summary>
        public static string Join(this IEnumerable<string> list, string delimiter = ", ") =>
            list?.ToList().Join(delimiter);

        /// <summary>
        /// Convenience method for joining dictionary key values into a string
        /// </summary>
        public static string Join(
            this IEnumerable<KeyValuePair<string, string>> list,
            string keyValueDelimiter,
            string delimiter = ", "
        ) => list?.Select(e => e.Join(keyValueDelimiter)).Where(e => !string.IsNullOrEmpty(e)).Join(delimiter);

        /// <summary>
        /// Convenience method so joining a list of strings
        /// </summary>
        public static string Join(this List<string> list, string delimiter = ", ") =>
            list == null ? null : string.Join(delimiter, list);

        /// <summary>
        /// Convenience method for joining key value pairs
        /// </summary>
        public static string Join(this KeyValuePair<string, string> pair, string delimiter) =>
            new List<string> { pair.Key, pair.Value }
                .Where(e => !string.IsNullOrEmpty(e))
                .Join(delimiter);

        /// <summary>
        /// Returns a random value in the related IEnumerable list
        /// </summary>
        public static T PickRandom<T>(this IEnumerable<T> source) => source.PickRandom(1).SingleOrDefault();

        /// <summary>
        /// Returns X number of random values in the related IEnumerable list
        /// </summary>
        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count) => source.Shuffle().Take(count);

        /// <summary>
        /// Returns source enumerable in randomized order
        /// </summary>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source) => source.OrderBy(x => Guid.NewGuid());
    }
}
