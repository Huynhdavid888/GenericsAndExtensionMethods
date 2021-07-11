using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
   static class ExtensionMethod
    {
        public static IEnumerable<int> FindOdds<IEnumberable>(IEnumerable<int> i)
        {
            return i.Where(e => e % 2 == 1);
        }
        
        public static T[] SortArray<T>(T[] f)
        {
            return f.OrderBy(e => e).ToArray();
        }
    }
}
