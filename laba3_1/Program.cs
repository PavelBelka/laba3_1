using System;

namespace laba3_1
{
    class Program
    {
        static int x1, x2, y1, y2, r = 0;
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты прямоугольника.");
            Console.Write("x1 = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите радиус окружности вписанной R:");
            r = Convert.ToInt32(Console.ReadLine());
            Rectangle_potomok potomok = new Rectangle_potomok(x1, y1, x2, y2, r);
            Rectangles rectangle = new Rectangles(x1, y1, x2, y2);
            rectangle.Forms();
            if (potomok.R == 0)
            {
                Console.WriteLine("Неверно введен радиус R вписанной окружности.");
            }
            else
            {
                Console.WriteLine("Нажмите 1 чтобы открыть 2 окно");
                if (Console.ReadLine() == "1")
                {
                    potomok.Forms_circle();
                    Console.WriteLine(potomok.ToString());
                }
            }
            Console.WriteLine(rectangle.ToString());
            //potomok.Forms();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
