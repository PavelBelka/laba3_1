using System;
using System.Windows.Forms;
using System.Drawing;
namespace laba3_1
{
    class Rectangles
    {
        protected int X1, X2, Y1, Y2;

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

        public void Forms()
        {
            Form Form1 = new Form();
            Form1.Size = new Size(X2 + 100, Y2 + 100);
            Form1.BackgroundImage = new Bitmap(X2 + 100, Y2 + 100);
            Rectangle recrt = new Rectangle(X1, Y1, Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));         
            Pen pen = new Pen(Color.Black, 2);
            Graphics gr = Graphics.FromImage(Form1.BackgroundImage);
            gr.DrawRectangle(pen, recrt);
            gr.DrawLine(pen, X1, Y1, X2, Y2);
            Form1.Show();
        }

        public override string ToString()
        {
            return $"Основной класс\nПрямоугольник с координатами [{X1}, {Y1}] и [{X2}, {Y2}] имеет диагональ:\nd = {DIAGONAL}";
        }
    }
}
