using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpArsenManukjanSnake
{
    class Walls
    {
        List<Figure> walllist;

        public Walls(int mapWidth, int mapHeight)
        {
            walllist = new List<Figure>();

            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, mapWidth-2, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth-2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            walllist.Add(upLine);
            walllist.Add(downLine);
            walllist.Add(leftLine);
            walllist.Add(rightLine);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in walllist)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }

            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in walllist)
            {
                wall.Draw();
            }
        }
    }
}





