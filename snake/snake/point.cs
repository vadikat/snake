using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public point(int _x, int _y, char _sym)
        {
            int x = _x;
            int y = _y;
            char sym = _sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
            
    }
}
