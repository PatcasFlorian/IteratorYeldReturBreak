using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        public static IEnumerable<int> GetMyMaxValue()
        {

            int maxValue = Int32.MaxValue;

            for (int items = 0; items <= maxValue; items++)
            {
                if (items == maxValue / 50000)
                {
                    Console.WriteLine("Using yield break");
                    yield break;
                }

                yield return items;
            }
        }
        static void Main(string[] args)
        {



            foreach (var i in GetMyMaxValue())
            {
                Console.WriteLine(i);
            }

        }
    }
}
