using System;

namespace Stone_Red_Utilities.FluentMath
{
    /// <summary>
    /// FloatFluent class
    /// </summary>
    public static class SingleFluent
    {
        /// <summary>
        /// Converts number to <see cref="decimal"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="decimal"/></returns>
        public static decimal ToDecimal(this float num)
        {
            return (decimal)num;
        }

        /// <summary>
        /// Converts number to <see cref="double"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="double"/></returns>
        public static double ToDouble(this float num)
        {
            return (float)num;
        }

        /// <summary>
        /// Converts number to <see cref="short"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="short"/></returns>
        public static short ToInt16(this float num)
        {
            return (short)num;
        }

        /// <summary>
        /// Converts number to <see cref="int"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="int"/></returns>
        public static int ToInt32(this float num)
        {
            return (int)num;
        }

        /// <summary>
        /// Converts number to <see cref="long"/>
        /// </summary>
        /// <param name="num"></param>
        /// <returns>Number as <see cref="long"/></returns>
        public static long ToInt64(this float num)
        {
            return (long)num;
        }

        /// <summary>
        /// Adds the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Add(this float num, float value)
        {
            return num + value;
        }

        /// <summary>
        /// Subtracts the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Subtract(this float num, float value)
        {
            return num - value;
        }

        /// <summary>
        /// Multiplys the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Multiply(this float num, float value)
        {
            return num * value;
        }

        /// <summary>
        /// Divides the two nums
        /// </summary>
        /// <param name="num"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Divide(this float num, float value)
        {
            return num / value;
        }

        /// <inheritdoc cref="MathF.Abs(float)"/>
        public static float Abs(this float num)
        {
            return MathF.Abs(num);
        }

        /// <inheritdoc cref="MathF.Acos(float)"/>
        public static float Acos(this float num)
        {
            return MathF.Acos(num);
        }

        /// <inheritdoc cref="MathF.Acosh(float)"/>
        public static float Acosh(this float num)
        {
            return MathF.Acosh(num);
        }

        /// <inheritdoc cref="MathF.Asin(float)"/>
        public static float Asin(this float num)
        {
            return MathF.Asin(num);
        }

        /// <inheritdoc cref="MathF.Asinh(float)"/>
        public static float Asinh(this float num)
        {
            return MathF.Asinh(num);
        }

        /// <inheritdoc cref="MathF.Atan(float)"/>
        public static float Atan(this float num)
        {
            return MathF.Atan(num);
        }

        /// <inheritdoc cref="MathF.Atan2(float,float)"/>
        public static float Atan2(this float num, float value)
        {
            return MathF.Atan2(num, value);
        }

        /// <inheritdoc cref="MathF.Atanh(float)"/>
        public static float Atanh(this float num)
        {
            return MathF.Atanh(num);
        }

        /// <inheritdoc cref="MathF.Cbrt(float)"/>
        public static float Cbrt(this float num)
        {
            return MathF.Cbrt(num);
        }

        /// <inheritdoc cref="MathF.Ceiling(float)"/>
        public static float Ceiling(this float num)
        {
            return MathF.Ceiling(num);
        }

        /// <inheritdoc cref="Math.Clamp(float,float,float)"/>
        public static float Clamp(this float num, float min, float max)
        {
            return Math.Clamp(num, min, max);
        }

        /// <inheritdoc cref="MathF.Cos(float)"/>
        public static float Cos(this float num)
        {
            return MathF.Cos(num);
        }

        /// <inheritdoc cref="MathF.Cosh(float)"/>
        public static float Cosh(this float num)
        {
            return MathF.Cosh(num);
        }

        /// <inheritdoc cref="MathF.Exp(float)"/>
        public static float Exp(this float num)
        {
            return MathF.Exp(num);
        }

        /// <inheritdoc cref="MathF.Floor(float)"/>
        public static float Floor(this float num)
        {
            return MathF.Floor(num);
        }

        /// <inheritdoc cref="MathF.IEEERemainder(float,float)"/>
        public static float IEEERemainder(this float num, float value)
        {
            return MathF.IEEERemainder(num, value);
        }

        /// <inheritdoc cref="MathF.Log(float)"/>
        public static float Log(this float num)
        {
            return MathF.Log(num);
        }

        /// <inheritdoc cref="MathF.Log(float,float)"/>
        public static float Log(this float num, float newBase)
        {
            return MathF.Log(num, newBase);
        }

        /// <inheritdoc cref="MathF.Log10(float)"/>
        public static float Log10(this float num)
        {
            return MathF.Log10(num);
        }

        /// <inheritdoc cref="MathF.Pow(float,float)"/>
        public static float Pow(this float num, float power)
        {
            return MathF.Pow(num, power);
        }

        /// <inheritdoc cref="MathF.Round(float)"/>
        public static float Round(this float num)
        {
            return MathF.Round(num);
        }

        /// <inheritdoc cref="MathF.Round(float,MidpointRounding)"/>
        public static float Round(this float num, MidpointRounding mode)
        {
            return MathF.Round(num, mode);
        }

        /// <inheritdoc cref="MathF.Round(float,int)"/>
        public static float Round(this float num, int digits)
        {
            return MathF.Round(num, digits);
        }

        /// <inheritdoc cref="MathF.Round(float,int,MidpointRounding)"/>
        public static float Round(this float num, int digits, MidpointRounding mode)
        {
            return MathF.Round(num, digits, mode);
        }

        /// <inheritdoc cref="MathF.Sign(float)"/>
        public static int Sign(this float num)
        {
            return MathF.Sign(num);
        }

        /// <inheritdoc cref="MathF.Sin(float)"/>
        public static float Sin(this float num)
        {
            return MathF.Sin(num);
        }

        /// <inheritdoc cref="MathF.Sinh(float)"/>
        public static float Sinh(this float num)
        {
            return MathF.Sinh(num);
        }

        /// <inheritdoc cref="MathF.Sqrt(float)"/>
        public static float Sqrt(this float num)
        {
            return MathF.Sqrt(num);
        }

        /// <inheritdoc cref="MathF.Tan(float)"/>
        public static float Tan(this float num)
        {
            return MathF.Tan(num);
        }

        /// <inheritdoc cref="MathF.Tanh(float)"/>
        public static float Tanh(this float num)
        {
            return MathF.Tanh(num);
        }

        /// <inheritdoc cref="MathF.Truncate(float)"/>
        public static float Truncate(this float num)
        {
            return MathF.Truncate(num);
        }
    }
}