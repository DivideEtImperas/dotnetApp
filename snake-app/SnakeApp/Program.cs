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

           List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);

            foreach (var item in numList)
            {
                Console.Write(item + " ");
            }

            numList.Remove(0);

            Console.ReadKey();
        }
        
    }
}
