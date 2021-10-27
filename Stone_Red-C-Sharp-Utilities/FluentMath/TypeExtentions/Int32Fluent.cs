using System;

namespace Stone_Red_Utilities.FluentMath
{
    /// <summary>
    /// IntegerFluent class
    /// </summary>
    public static class Int32Fluent
    {
        /// <summary>
        /// Converts number to <see cref="decimal"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="decimal"/></returns>
        public static decimal ToDecimal(this int num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="float"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="float"/></returns>
        public static float ToSingle(this int num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="double"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="double"/></returns>
        public static double ToDouble(this int num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="short"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="short"/></returns>
        public static short ToInt16(this int num)
        {
            return (short)num;
        }

        /// <summary>
        /// Converts number to <see cref="long"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="long"/></returns>
        public static long ToInt64(this int num)
        {
            return num;
        }

        /// <summary>
        /// Adds the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Add(this int num, int value)
        {
            return num + value;
        }

        /// <summary>
        /// Subtracts the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Subtract(this int num, int value)
        {
            return num - value;
        }

        /// <summary>
        /// Multiples the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Multiply(this int num, int value)
        {
            return num * value;
        }

        /// <summary>
        /// Divides the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Divide(this int num, int value)
        {
            return num / value;
        }

        /// <inheritdoc cref="Math.Abs(int)"/>
        public static int Abs(this int num)
        {
            return Math.Abs(num);
        }

        /// <inheritdoc cref="Math.Clamp(int,int,int)"/>
        public static int Clamp(this int num, int min, int max)
        {
            return Math.Clamp(num, min, max);
        }

        /// <inheritdoc cref="Math.Sign(int)"/>
        public static int Sign(this int num)
        {
            return Math.Sign(num);
        }
    }
}