using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyUniversityProject.Serviece
{ 
    static class LinqExtensions
    {
        public static IEnumerable<IEnumerable<T>> CombinationsWithoutRepetition<T>(
            this IEnumerable<T> items,
            int ofLength)
        {
            return (ofLength == 1) ?
                items.Select(item => new[] { item }) :
                items.SelectMany((item, i) => items.Skip(i + 1)
                                                   .CombinationsWithoutRepetition(ofLength - 1)
                                                   .Select(result => new T[] { item }.Concat(result)));
        }

        public static IEnumerable<IEnumerable<T>> CombinationsWithoutRepetition<T>(
            this IEnumerable<T> items,
            int ofLength,
            int upToLength)
        {
            return Enumerable.Range(ofLength, Math.Max(0, upToLength - ofLength + 1))
                             .SelectMany(len => items.CombinationsWithoutRepetition(ofLength: len));
        }

    }
}
