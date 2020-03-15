using System;
using System.Collections.Generic;
using System.Text;

namespace TabletopDirector.Utilities
{
    public class Flip
    {
        private static Random _random = new Random();
        public static Coin Single()
        {
            return _random.Next(0, 1) == 0 ? Coin.Heads : Coin.Tails;
        }
        public static List<Coin> Multiple(int numberOfFlips)
        {
            List<Coin> results = new List<Coin>();
            for (var i = 1; i <= numberOfFlips; i++) 
            {
                Coin result = _random.Next(0, 1) == 0 ? Coin.Heads : Coin.Tails;
                results.Add(result);
            }
            return results;
        }
    }

    public enum Coin
    {
        Heads,
        Tails
    }
}
