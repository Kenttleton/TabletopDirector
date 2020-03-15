using System;

namespace TabletopDirector.Utilities
{
    public class Roll
    {
        private static Random _random = new Random();
        public static int D3(int numberOfDice)
        {
            int result = 0;
            for (var i = 1; i <= numberOfDice; i++)
            {
                result += _random.Next(1, (int)Dice.D3);
            }
            return result;
        }
        public static int D4(int numberOfDice)
        {
            int result = 0;
            for (var i = 1; i <= numberOfDice; i++)
            {
                result += _random.Next(1, (int)Dice.D4);
            }
            return result;
        }
        public static int D6(int numberOfDice)
        {
            int result = 0;
            for (var i = 1; i <= numberOfDice; i++)
            {
                result += _random.Next(1, (int)Dice.D6);
            }
            return result;
        }
        public static int D8(int numberOfDice)
        {
            int result = 0;
            for (var i = 1; i <= numberOfDice; i++)
            {
                result += _random.Next(1, (int)Dice.D8);
            }
            return result;
        }
        public static int D10(int numberOfDice)
        {
            int result = 0;
            for (var i = 1; i <= numberOfDice; i++)
            {
                result += _random.Next(1, (int)Dice.D10);
            }
            return result;
        }
        public static int D12(int numberOfDice)
        {
            int result = 0;
            for (var i = 1; i <= numberOfDice; i++)
            {
                result += _random.Next(1, (int)Dice.D12);
            }
            return result;
        }
        public static int D20(int numberOfDice)
        {
            int result = 0;
            for (var i = 1; i <= numberOfDice; i++)
            {
                result += _random.Next(1, (int)Dice.D20);
            }
            return result;
        }
    }

    public enum Dice
    {
        None,
        D3 = 3,
        D4 = 4,
        D6 = 6,
        D8 = 8,
        D10 = 10,
        D12 = 12,
        D20 = 20
    }
}
