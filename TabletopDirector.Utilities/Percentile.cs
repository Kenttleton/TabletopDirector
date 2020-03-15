using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopDirector.Utilities
{
    public class Percentile
    {
        private static Random _random = new Random();
        public static int Roll(int max, int quantity)
        {
            int result = 0;
            for (var i = 1; i <= quantity; i++)
            {
                result += _random.Next(1, max);
            }
            return result;
        }
    }
}
