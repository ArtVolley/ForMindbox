using System;
using figureSquare;

namespace TestExe
{
    class Program
    {
        static void Main()
        {
            Figure t = new Figure(3, 4, 5);
            double ttt = t.Square();
            Console.WriteLine(t.Square());
            Figure p = new Figure(2);
            double ppp = p.Square();
            Console.WriteLine(t.IsRightTriangle());
            Console.WriteLine(p.Square());
            
        }
    }
}
