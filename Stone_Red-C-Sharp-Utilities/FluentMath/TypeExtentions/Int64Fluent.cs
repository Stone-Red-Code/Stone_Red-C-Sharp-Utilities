using System;

namespace Stone_Red_Utilities.FluentMath
{
    /// <summary>
    /// IntegerFluent class
    /// </summary>
    public static class Int64Fluent
    {
        /// <summary>
        /// Converts number to <see cref="decimal"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="decimal"/></returns>
        public static decimal ToDecimal(this long num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="float"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="float"/></returns>
        public static float ToSingle(this long num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="double"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="double"/></returns>
        public static double ToDouble(this long num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="short"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="short"/></returns>
        public static short ToInt16(this long num)
        {
            return (short)num;
        }

        /// <summary>
        /// Converts number to <see cref="int"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="int"/></returns>
        public static int ToInt32(this long num)
        {
            return (int)num;
        }

        /// <summary>
        /// Adds the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long Add(this long num, long value)
        {
            return num + value;
        }

        /// <summary>
        /// Subtracts the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long Subtract(this long num, long value)
        {
            return num - value;
        }

        /// <summary>
        /// Multiplys the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long Multiply(this long num, long value)
        {
            return num * value;
        }

        /// <summary>
        /// Divides the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long Divide(this long num, long value)
        {
            return num / value;
        }

        /// <inheritdoc cref="Math.Abs(long)"/>
        public static long Abs(this long num)
        {
            return Math.Abs(num);
        }

        /// <inheritdoc cref="Math.Clamp(long,long,long)"/>
        public static long Clamp(this long num, long min, long max)
        {
            return Math.Clamp(num, min, max);
        }

        /// <inheritdoc cref="Math.Sign(long)"/>
        public static long Sign(this long num)
        {
            return Math.Sign(num);
        }
    }
}