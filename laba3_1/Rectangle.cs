using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_1
{
    class Rectangles
    {
        int X1, X2, Y1, Y2;

        public Rectangles()
        {
        }

        public Rectangles(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        
        int DIAGONAL
        {
            get
            { 
                return (int)Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
            }
        }

        public override string ToString()
        {
            return $"Основной класс\nПрямоугольник с координатами [{X1}, {Y1}] и [{X2}, {Y2}] имеет диагональ:\nd = {DIAGONAL}";
        }
    }
}
