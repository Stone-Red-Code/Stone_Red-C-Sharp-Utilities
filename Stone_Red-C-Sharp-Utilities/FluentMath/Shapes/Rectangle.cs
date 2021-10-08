using System;

namespace Stone_Red_Utilities.FluentMath.Shapes
{
    /// <summary>
    /// Represents a rectangle
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// The length of the <see cref="Rectangle"/>
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// The width of the <see cref="Rectangle"/>
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// The diagonal of the <see cref="Rectangle"/>
        /// </summary>
        public double Diagonal => System.Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2));

        /// <summary>
        /// The area of the <see cref="Rectangle"/>
        /// </summary>
        public double Area => Length * Width;

        /// <summary>
        /// The perimeter of the <see cref="Rectangle"/>
        /// </summary>
        public double Perimeter => Length * 2 + Width * 2;

        /// <summary>
        /// Creates a new rectangle instance
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
    }
}