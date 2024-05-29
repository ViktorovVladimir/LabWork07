

namespace UtilsLabWork07NameSpaceL
{
    using System;

    //--.
    public class Test
    {
        public static void Main()
        {
            string message;
            

            //while(true)
            //{



            //--. Get an input string
            Console.WriteLine("Enter string to reverse: ");
            message = Console.ReadLine();

            //--. Reverse the string
            Utils.Reverse(ref message);

            //--. Display the result
            Console.WriteLine(message);



            //}


        }
    }
}
