using System;
using System.IO;

namespace CopyFileUpperNameSpace
{
    class CopyFileUpper
    {
        //--.
        static void Main()
        {
            string sFrom, sTo;
            StreamReader srFrom;
            StreamWriter swTo;

            //--. Promt for input file name
            Console.Write("Copy from: ");
            sFrom = Console.ReadLine();

            //--. Promt for output file name
            Console.Write("Copy to: ");
            sTo = Console.ReadLine();

            //--.
            Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);

            //--.
            try
            {
                //--.
                srFrom = new StreamReader(sFrom);
                swTo = new StreamWriter(sTo);

                //--.
                while (srFrom.Peek() != -1)
                {
                    string sBuffer = srFrom.ReadLine();
                    sBuffer = sBuffer.ToUpper();
                    swTo.WriteLine(sBuffer);
                }

                //--.
                swTo.Close();
                srFrom.Close();
            }
            catch (FileNotFoundException)
            {
                //--.
                Console.WriteLine("Input file not found");
            }
            catch (Exception e)
            {
                //--.
                Console.WriteLine("Unexpected exception");
                Console.WriteLine(e.ToString() );
            }
        }
    }
}