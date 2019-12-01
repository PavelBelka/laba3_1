using System;

namespace laba3_1
{
    class Program
    {
        static int x1, x2, y1, y2;
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты прямооугольника.");
            Console.Write("x1 = ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToInt32(Console.ReadLine());
            Rectangles rectangle = new Rectangles(x1, y1, x2, y2);
            Rectangle_potomok potomok = new Rectangle_potomok(x1, y1, x2, y2);
            Console.WriteLine(rectangle.ToString());
            potomok.Forms();
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
