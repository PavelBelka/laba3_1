using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace laba3_1
{
    class Rectangle_potomok: Rectangles
    {
        int X1, Y1, X2, Y2, diagonal;
        public Rectangle_potomok(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public void Forms()
        {
            Form Form1 = new Form();
            Form1.Size = new Size(100, 100);
            Form1.BackgroundImage = new Bitmap(100, 100);
            Rectangle recrt = new Rectangle(X1, Y1, Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));
            Pen pen = new Pen(Color.Black, 2);
            Graphics gr = Graphics.FromImage(Form1.BackgroundImage);
            gr.DrawRectangle(pen, recrt);
            Form1.Show();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
