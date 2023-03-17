using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Vertikalline : Figure
    {
        

        public Vertikalline(int yLeft, int yRight, int x, char sym)
        {
            pList = new List<point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
        }

        
        
    }
}
