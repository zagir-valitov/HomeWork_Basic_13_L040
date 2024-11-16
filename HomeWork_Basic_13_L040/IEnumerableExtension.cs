using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Basic_13_L040
{
    public static class IEnumerableExtension
    {        
        public static IEnumerable<TSource> Top<TSource>(this IEnumerable<TSource> source, int percent = 50)
        {
            if (percent < 1 || percent > 100)
            {
                Console.WriteLine("--- !!! ---");
            }            
            percent = Convert.ToInt32(Convert.ToDouble(percent) * Convert.ToDouble(source.Count()) * 0.01);
            return source.TakeLast(percent);
        }
        public static IEnumerable<TSource> Top<TSource, TResult>(this IEnumerable<TSource> source, int percent, Func<TSource, TResult> selector)
        {
            if (percent < 1 || percent > 100)
            {
                throw new ArgumentException("The argument must be in the range from 1 - 100");
            }            
            source = source.OrderByDescending(selector);     
            percent = Convert.ToInt32(Convert.ToDouble(percent) * Convert.ToDouble(source.Count()) * 0.01);
            return source.Take(percent);
        }        
    }
}