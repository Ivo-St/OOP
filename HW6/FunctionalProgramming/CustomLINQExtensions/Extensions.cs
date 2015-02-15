namespace CustomLINQExtensions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(x => !predicate(x));
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var list = collection.ToList();
            for (int i = 0; i < count - 1; i++)
            {
                list.AddRange(collection);
            }

            return list as IEnumerable<T>;
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            var result = collection.Where((x) =>
                {
                    foreach (var y in suffixes)
                    {
                        if (x.EndsWith(y))
                        {
                            return true;
                        }
                    }
                    return false;
                });

            return result;
        }
    }
}
