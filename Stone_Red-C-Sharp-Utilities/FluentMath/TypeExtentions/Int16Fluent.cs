using System;

namespace Stone_Red_Utilities.FluentMath
{
    /// <summary>
    /// IntegerFluent class
    /// </summary>
    public static class Int16Fluent
    {
        /// <summary>
        /// Converts number to <see cref="decimal"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="decimal"/></returns>
        public static decimal ToDecimal(this short num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="float"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="float"/></returns>
        public static float ToSingle(this short num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="double"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="double"/></returns>
        public static double ToDouble(this short num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="int"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="int"/></returns>
        public static int ToInt32(this short num)
        {
            return num;
        }

        /// <summary>
        /// Converts number to <see cref="long"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="long"/></returns>
        public static long ToInt64(this short num)
        {
            return num;
        }

        /// <summary>
        /// Adds the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Add(this short num, short value)
        {
            return num + value;
        }

        /// <summary>
        /// Subtracts the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Subtract(this short num, short value)
        {
            return num - value;
        }

        /// <summary>
        /// Multiples the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Multiply(this short num, short value)
        {
            return num * value;
        }

        /// <summary>
        /// Divides the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Divide(this short num, short value)
        {
            return num / value;
        }

        /// <inheritdoc cref="Math.Abs(short)"/>
        public static short Abs(this short num)
        {
            return Math.Abs(num);
        }

        /// <inheritdoc cref="Math.Clamp(short,short,short)"/>
        public static short Clamp(this short num, short min, short max)
        {
            return Math.Clamp(num, min, max);
        }

        /// <inheritdoc cref="Math.Sign(short)"/>
        public static int Sign(this short num)
        {
            return Math.Sign(num);
        }
    }
}