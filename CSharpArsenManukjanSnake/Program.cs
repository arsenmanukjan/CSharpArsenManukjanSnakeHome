using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpArsenManukjanSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);  // пришлось добавить, потому что не запускалось с SetBufferSize
            Console.SetBufferSize(80, 25);  // проверка

            // Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();
            
            Console.ReadLine();


            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            p.Draw();
            Console.ReadLine();  
            Console.ReadLine();
        }
    }
}


