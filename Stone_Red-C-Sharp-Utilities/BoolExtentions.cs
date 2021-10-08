namespace Stone_Red_Utilities.BoolExtentions
{
    /// <summary>
    /// <see cref="bool"/> Extentions
    /// </summary>
    public static class BoolExt
    {
        /// <summary>
        /// Sets value to true if input is true. If input is false the value will not change.
        /// </summary>
        /// <param name="bol"></param>
        /// <param name="input"></param>
        public static void OneWayTrue(this ref bool bol, bool input)
        {
            if (bol == false && input)
            {
                bol = true;
            }
        }

        /// <summary>
        /// Sets value to false if input is false. If input is true the value will not change.
        /// </summary>
        /// <param name="bol"></param>
        /// <param name="input"></param>
        public static void OneWayFalse(this ref bool bol, bool input)
        {
            if (bol == true && !input)
            {
                bol = false;
            }
        }

        /// <summary>
        /// Converts bool to int.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int ToInt(this bool input)
        {
            return input ? 1 : 0;
        }

        /// <summary>
        /// Converts int to bool.
        /// </summary>
        /// <param name="bol"></param>
        /// <param name="input"></param>
        public static void FromInt(this ref bool bol, int input)
        {
            bol = input == 1;
        }
    }
}