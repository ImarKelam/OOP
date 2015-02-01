namespace LINQExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LinqExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(a => !predicate(a));
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var output = collection.ToList();

            for (int i = 0; i < count - 1; i++)
            {
                output.AddRange(collection);
            }

            return output;
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            var output = new List<string>();

            foreach (var item in collection)
	        {
                foreach (var suffix in suffixes)
                {
                    if (item.EndsWith(suffix))
                        output.Add(item);
                }
	        }

            return output as IEnumerable<string>;
        }
    }
}
