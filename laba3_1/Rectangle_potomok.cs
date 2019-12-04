using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace laba3_1
{
    class Rectangle_potomok: Rectangles
    {
        int R;
        public Rectangle_potomok(int x1, int y1, int x2, int y2, int r)
            :base(x1,y1,x2,y2)
        {
            R = r;
        }

        public void Forms_circle()
        {
            Form Form_circle = new Form();
            Form_circle.Size = new Size(100, 100);
            Form_circle.BackgroundImage = new Bitmap(100, 100);
            Rectangle recrt = new Rectangle(X1, Y1, Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));
            Pen pen = new Pen(Color.Black, 2);
            Graphics gr = Graphics.FromImage(Form_circle.BackgroundImage);
            gr.DrawRectangle(pen, recrt);
            Form_circle.Show();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
