﻿

namespace InterfaceTestNameSpace
{
    using System;

    //--.
    public class Test
    {
        public static void Main()
        {
            
            int i = 0;
            ulong ul = 0;
            string s = "Test";

            Console.WriteLine( "int: {0}", Utils.IsItFormattable(i)    );
            Console.WriteLine( "ulong: {0}", Utils.IsItFormattable(ul) );
            Console.WriteLine("string: {0}", Utils.IsItFormattable(s))   ;
        }
    }
}
