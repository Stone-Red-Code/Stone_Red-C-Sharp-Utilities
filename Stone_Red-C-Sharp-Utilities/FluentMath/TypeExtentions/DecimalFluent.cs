using System;

namespace Stone_Red_Utilities.FluentMath
{
    /// <summary>
    /// DecimalFluent class
    /// </summary>
    public static class DecimalFluent
    {
        /// <summary>
        /// Converts number to <see cref="decimal"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="decimal"/></returns>
        public static double ToDouble(this decimal num)
        {
            return (double)num;
        }

        /// <summary>
        /// Converts number to <see cref="float"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="float"/></returns>
        public static float ToSingle(this decimal num)
        {
            return (float)num;
        }

        /// <summary>
        /// Converts number to <see cref="short"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="short"/></returns>
        public static short ToInt16(this decimal num)
        {
            return (short)num;
        }

        /// <summary>
        /// Converts number to <see cref="int"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="int"/></returns>
        public static int ToInt32(this decimal num)
        {
            return (int)num;
        }

        /// <summary>
        /// Converts number to <see cref="long"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="long"/></returns>
        public static long ToInt64(this decimal num)
        {
            return (long)num;
        }

        /// <summary>
        /// Adds the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Add(this decimal num, decimal value)
        {
            return num + value;
        }

        /// <summary>
        /// Subtracts the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Subtract(this decimal num, decimal value)
        {
            return num - value;
        }

        /// <summary>
        /// Multiples the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Multiply(this decimal num, decimal value)
        {
            return num * value;
        }

        /// <summary>
        /// Divides the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal Divide(this decimal num, decimal value)
        {
            return num / value;
        }

        /// <inheritdoc cref="Math.Abs(decimal)"/>
        public static decimal Abs(this decimal num)
        {
            return Math.Abs(num);
        }

        /// <inheritdoc cref="Math.Ceiling(decimal)"/>
        public static decimal Ceiling(this decimal num)
        {
            return Math.Ceiling(num);
        }

        /// <inheritdoc cref="Math.Clamp(decimal,decimal,decimal)"/>
        public static decimal Clamp(this decimal num, decimal min, decimal max)
        {
            return Math.Clamp(num, min, max);
        }

        /// <inheritdoc cref="Math.Floor(decimal)"/>
        public static decimal Floor(this decimal num)
        {
            return Math.Floor(num);
        }

        /// <inheritdoc cref="Math.Round(decimal)"/>
        public static decimal Round(this decimal num)
        {
            return Math.Round(num);
        }

        /// <inheritdoc cref="Math.Round(decimal,MidpointRounding)"/>
        public static decimal Round(this decimal num, MidpointRounding mode)
        {
            return Math.Round(num, mode);
        }

        /// <inheritdoc cref="Math.Round(decimal,int)"/>
        public static decimal Round(this decimal num, int digits)
        {
            return Math.Round(num, digits);
        }

        /// <inheritdoc cref="Math.Round(decimal,int,MidpointRounding)"/>
        public static decimal Round(this decimal num, int digits, MidpointRounding mode)
        {
            return Math.Round(num, digits, mode);
        }

        /// <inheritdoc cref="Math.Sign(decimal)"/>
        public static int Sign(this decimal num)
        {
            return Math.Sign(num);
        }

        /// <inheritdoc cref="Math.Truncate(decimal)"/>
        public static decimal Truncate(this decimal num)
        {
            return Math.Truncate(num);
        }
    }
}