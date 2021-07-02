using System;
using System.Collections.Generic;
using System.Linq;
namespace Generics
{
    public static class ExtensionMethods
    {
        static ExtensionMethods()
        {
        }
        public static IEnumerable<int> FindOdds(this IEnumerable<int> input)
        {
            return input.Where(item => item % 2 != 0);
        }
        public static T[] SortArray<T>(this T[] arrayInput)
        {
            return arrayInput.OrderBy(item => item).ToArray();
        }
    }
}
