using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Point
    {
        public int x;
        public int y;
        public Point()
        {
            x = 10;
            y = 20;
        }
        public Point(int x)
        {
            this.x = x;
            y = 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(20);
            Console.WriteLine(p.x + " " + p.y); 
        }
    }
}
