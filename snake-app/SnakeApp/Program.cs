using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
         
            p1.Draw();

            Point p2 = new Point(4,5,'#');
       
            p2.Draw();

            HoorizontalLine line = new HoorizontalLine(5,10, 8, '+');
            line.Draw();

            Console.ReadKey();
        }
        
    }
}
