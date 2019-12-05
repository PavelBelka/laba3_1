using System;
using System.Windows.Forms;
using System.Drawing;

namespace laba3_1
{
    class Rectangle_potomok: Rectangles
    {
        private int radius;
        public int R
        {
            get
            {
                return radius;
            }
            set
            {
                if ((value < ((X2 - X1) / 2)) && (value < ((Y2 - Y1) / 2)))
                {
                    radius = value;
                }
                else
                {
                    radius = 0;
                }
            }
        }
        public Rectangle_potomok(int x1, int y1, int x2, int y2, int r)
            :base(x1,y1,x2,y2)
        {
            R = r;
        }

        public void Forms_circle()
        {
            Form Form_circle = new Form();
            Form_circle.Size = new Size(X2 + 100, Y2 + 100);
            Form_circle.BackgroundImage = new Bitmap(X2 + 100, Y2 + 100);
            Rectangle recrt = new Rectangle(X1, Y1, Math.Abs(X1 - X2), Math.Abs(Y1 - Y2));
            Pen pen = new Pen(Color.Black, 2);
            Graphics gr = Graphics.FromImage(Form_circle.BackgroundImage);
            gr.DrawRectangle(pen, recrt);
            gr.DrawEllipse(pen, (X2 / 2) - R, (Y2 / 2) - R, R * 2, R * 2);
            Form_circle.Show();
        }

        int Square
        {
            get
            {
                return ((X2 - X1) * (Y2 - Y1)) - (int)(Math.PI * Math.Pow(R, 2));
            }
        }

        public override string ToString()
        {
            return $"Класс потомок:\nПрямоугольник с координатами [{X1}, {Y1}] и [{X2}, {Y2}] и окружностью радиуса {R} имеет площадь\nфигуры между кругом и прямоугольником:\nS = {Square}";
        }

    }
}
