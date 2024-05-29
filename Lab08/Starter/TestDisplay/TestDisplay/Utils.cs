


namespace TestDisplayNameSpace
{
    using System;

    //--.
    class Utils
    {   
        
        //--.
        public static void Display( object item )
        {
            IPrintable ip;

            ip = (item as IPrintable);

            if (ip != null)
                ip.Print();
            else
                Console.WriteLine( "else  " + item.ToString() );


        }
    }
}