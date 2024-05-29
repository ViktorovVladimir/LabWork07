
namespace TestDisplayNameSpace
{
    using System;

    //--.
    class Coordinate : IPrintable
    {
        double x;
        double y;

        //--.
        public Coordinate()
        {
            x = 0;
            y = 0;
        }

        //--.
        public Coordinate(double px, double py)
        {
            x = px;
            y = py;
        }

        //--.
        public void Print()
        {
            Console.WriteLine("( {0}, {1} )", x, y);
        }
    }

}