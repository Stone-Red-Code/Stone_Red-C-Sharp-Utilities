using System;

namespace Stone_Red_Utilities.FluentMath
{
    /// <summary>
    /// DoubleFluent class
    /// </summary>
    public static class DoubleFluent
    {
        /// <summary>
        /// Converts number to <see cref="decimal"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="decimal"/></returns>
        public static decimal ToDecimal(this double num)
        {
            return (decimal)num;
        }

        /// <summary>
        /// Converts number to <see cref="float"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="float"/></returns>
        public static float ToSingle(this double num)
        {
            return (float)num;
        }

        /// <summary>
        /// Converts number to <see cref="short"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="short"/></returns>
        public static short ToInt16(this double num)
        {
            return (short)num;
        }

        /// <summary>
        /// Converts number to <see cref="int"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="int"/></returns>
        public static int ToInt32(this double num)
        {
            return (int)num;
        }

        /// <summary>
        /// Converts number to <see cref="long"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="long"/></returns>
        public static long ToInt64(this double num)
        {
            return (long)num;
        }

        /// <summary>
        /// Adds the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double Add(this double num, double value)
        {
            return num + value;
        }

        /// <summary>
        /// Subtracts the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double Subtract(this double num, double value)
        {
            return num - value;
        }

        /// <summary>
        /// Multiples the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double Multiply(this double num, double value)
        {
            return num * value;
        }

        /// <summary>
        /// Divides the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static double Divide(this double num, double value)
        {
            return num / value;
        }

        /// <inheritdoc cref="Math.Abs(double)"/>
        public static double Abs(this double num)
        {
            return Math.Abs(num);
        }

        /// <inheritdoc cref="Math.Acos(double)"/>
        public static double Acos(this double num)
        {
            return Math.Acos(num);
        }

        /// <inheritdoc cref="Math.Acosh(double)"/>
        public static double Acosh(this double num)
        {
            return Math.Acosh(num);
        }

        /// <inheritdoc cref="Math.Asin(double)"/>
        public static double Asin(this double num)
        {
            return Math.Asin(num);
        }

        /// <inheritdoc cref="Math.Asinh(double)"/>
        public static double Asinh(this double num)
        {
            return Math.Asinh(num);
        }

        /// <inheritdoc cref="Math.Atan(double)"/>
        public static double Atan(this double num)
        {
            return Math.Atan(num);
        }

        /// <inheritdoc cref="Math.Atan2(double,double)"/>
        public static double Atan2(this double num, double valuee)
        {
            return Math.Atan2(num, valuee);
        }

        /// <inheritdoc cref="Math.Atanh(double)"/>
        public static double Atanh(this double num)
        {
            return Math.Atanh(num);
        }

        /// <inheritdoc cref="Math.Cbrt(double)"/>
        public static double Cbrt(this double num)
        {
            return Math.Cbrt(num);
        }

        /// <inheritdoc cref="Math.Ceiling(double)"/>
        public static double Ceiling(this double num)
        {
            return Math.Ceiling(num);
        }

        /// <inheritdoc cref="Math.Clamp(double,double,double)"/>
        public static double Clamp(this double num, double min, double max)
        {
            return Math.Clamp(num, min, max);
        }

        /// <inheritdoc cref="Math.Cos(double)"/>
        public static double Cos(this double num)
        {
            return Math.Cos(num);
        }

        /// <inheritdoc cref="Math.Cosh(double)"/>
        public static double Cosh(this double num)
        {
            return Math.Cosh(num);
        }

        /// <inheritdoc cref="Math.Exp(double)"/>
        public static double Exp(this double num)
        {
            return Math.Exp(num);
        }

        /// <inheritdoc cref="Math.Floor(double)"/>
        public static double Floor(this double num)
        {
            return Math.Floor(num);
        }

        /// <inheritdoc cref="Math.IEEERemainder(double,double)"/>
        public static double IEEERemainder(this double num, double valuee)
        {
            return Math.IEEERemainder(num, valuee);
        }

        /// <inheritdoc cref="Math.Log(double)"/>
        public static double Log(this double num)
        {
            return Math.Log(num);
        }

        /// <inheritdoc cref="Math.Log(double,double)"/>
        public static double Log(this double num, double newBase)
        {
            return Math.Log(num, newBase);
        }

        /// <inheritdoc cref="Math.Log10(double)"/>
        public static double Log10(this double num)
        {
            return Math.Log10(num);
        }

        /// <inheritdoc cref="Math.Pow(double,double)"/>
        public static double Pow(this double num, double power)
        {
            return Math.Pow(num, power);
        }

        /// <inheritdoc cref="Math.Round(double)"/>
        public static double Round(this double num)
        {
            return Math.Round(num);
        }

        /// <inheritdoc cref="Math.Round(double,MidpointRounding)"/>
        public static double Round(this double num, MidpointRounding mode)
        {
            return Math.Round(num, mode);
        }

        /// <inheritdoc cref="Math.Round(double,int)"/>
        public static double Round(this double num, int digits)
        {
            return Math.Round(num, digits);
        }

        /// <inheritdoc cref="Math.Round(double,int,MidpointRounding)"/>
        public static double Round(this double num, int digits, MidpointRounding mode)
        {
            return Math.Round(num, digits, mode);
        }

        /// <inheritdoc cref="Math.Sign(double)"/>
        public static int Sign(this double num)
        {
            return Math.Sign(num);
        }

        /// <inheritdoc cref="Math.Sin(double)"/>
        public static double Sin(this double num)
        {
            return Math.Sin(num);
        }

        /// <inheritdoc cref="Math.Sinh(double)"/>
        public static double Sinh(this double num)
        {
            return Math.Sinh(num);
        }

        /// <inheritdoc cref="Math.Sqrt(double)"/>
        public static double Sqrt(this double num)
        {
            return Math.Sqrt(num);
        }

        /// <inheritdoc cref="Math.Tan(double)"/>
        public static double Tan(this double num)
        {
            return Math.Tan(num);
        }

        /// <inheritdoc cref="Math.Tanh(double)"/>
        public static double Tanh(this double num)
        {
            return Math.Tanh(num);
        }

        /// <inheritdoc cref="Math.Truncate(double)"/>
        public static double Truncate(this double num)
        {
            return Math.Truncate(num);
        }
    }
}