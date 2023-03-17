using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.SetBufferSize(80, 25); 

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '@');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '@');
            Vertikalline leftline = new Vertikalline(0, 24, 0, '@');
            Vertikalline rightline = new Vertikalline(0, 24, 78, '@');

            upLine.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            point p = new point(4, 5, '$');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
        }

      
    }
}
