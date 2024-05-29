


namespace InterfaceTestNameSpace
{
    using System;

    //--.
    class Utils
    {
        
        //--.
        public static void Reverse(ref string s)
        {
            string sRev = "";

            //--.
            for(int k=s.Length-1; k >= 0; k--)
            {
                sRev = sRev + s[k];
            }

            //--. Return result to caller
            s = sRev;
        }


        //--.
        public static bool IsItFormattable(object x)
        {   
            if(x is IFormattable)
                return true;
            else
                return false;
        }   

    }
}