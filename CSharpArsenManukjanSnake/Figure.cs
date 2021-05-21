using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpArsenManukjanSnake
{
    class Figure 
    {
        protected List<Point> pList;

        public new void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}