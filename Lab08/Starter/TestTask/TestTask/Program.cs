namespace TestTaskNameSpace
{
    using System;
    using System.Collections;

    //--.
    public class Test
    {
        public static void Main()
        {
            ArrayList boooks = new ArrayList();

            //--. Init random number generator
            Random rndPages = new Random();
            Random rndYear = new Random();

            //--. Generate 10 books betwen with years: 1945 - 2024;
            //--.                          with pages: 30 - 1000;


            for(int i= 0; i<10; i++)
            {
                int pages = rndPages.Next(29, 1001);
                int year = rndYear.Next(1944, 2025);
                Book temp = new Book();
                temp.SetBook( i.ToString(), (i + 1000).ToString(), pages, year);
                boooks.Add(temp);
            }

            //--. Sort ArrayList
            boooks.Sort();

            //--.
            foreach(Book temp in boooks)
                temp.Show();


        }
    }

}