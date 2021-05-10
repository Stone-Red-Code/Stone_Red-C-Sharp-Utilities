using System;
using System.Collections.Generic;
using System.Linq;
using Stone_Red_Utilities.RandomExtentions;

namespace Stone_Red_C_Sharp_Utilities_Test
{
    internal class Program
    {
        private enum MyEnum
        {
            a,
            b,
            c
        }

        private static void Main()
        {
            Random rnd = new Random();
            MyEnum randomItem = rnd.NextEnum(new MyEnum());
            Console.WriteLine(randomItem);
        }
    }
}