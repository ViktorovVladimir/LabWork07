using System;

namespace TestTaskNameSpace
{
    using System;
    using System.Collections;

    //--.
    class Book : IComparable
    {
        String author, title;
        int pages, year;

        //--.
        public Book()
        {
            author = "";
            title = "";
            pages = 0;
            year = 0;
        }

        //--.
        public void SetBook(String author, String title, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }

        //--.
        public void Show()
        {
            Console.WriteLine("\nКнига:\n  Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n", author, title, year, pages);
        }

        public int CompareTo(object obj)
        {
            //--.
            Book it = (Book)obj;
            //--.
            if(this.year == it.year)
                return 0;
            else if (this.year > it.year)
                return 1;
            else
                return -1;
        }
    }

}
