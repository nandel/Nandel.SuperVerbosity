using System;

namespace Nandel.SuperVerbosity
{
    public static class IntExtensions
    {
        /// <summary>
        /// Let me write value % 2 != 0 for you
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }

        /// <summary>
        /// Let me write value % 1 == 0 for you
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        /// <summary>
        /// Is this number a prime? will be expensive to calculate that...
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPrime(this int value)
        {
            if (value <= 1) return false;
            if (value == 2) return true;
            if (value % 2 == 0) return false;

            var boundary = (int) Math.Floor(Math.Sqrt(value));

            for (var i = 3; i <= boundary; i += 2)
                if (value % i == 0)
                    return false;

            return true;
        }

        /// <summary>
        /// Realy lazy to write value > 0
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPositive(this int value)
        {
            return value > 0;
        }

        /// <summary>
        /// Maybe coding is not for you right? value < 0
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNegative(this int value)
        {
            return value < 0;
        }
    }
}
