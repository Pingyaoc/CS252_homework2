using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS252_homework2
{
    internal class DrawSquare
    {
        private int _length;
        public Bitmap b;
        public Pen p;

        public int Length
        {
            get { return this._length; }
            set
            {
                this._length = value;
                if (value > 5)
                {
                    this._length = 5;
                    MessageBox.Show("Maximum length is 5");
                }
                else if (value <= 0)
                    this._length = 1;
                else
                    this._length = value;
            }
        }

        private int _width;

        public int Width
        {
            get { return this._width; }
            set
            {
                this._width = value;
                if (value > 5)
                {
                    this._width = 5;
                    MessageBox.Show("Maximum width is 5");
                }
                else if (value <= 0)
                    this._width = 1;
                else
                    this._width = value;
            }
        }

        private void line(Graphics g, Pen p, int x1, int y1, int x2, int y2)
        {
            g.DrawLine(p, x1, y1, x2, y2); // NEW 畫線座標
        }

        public int UserDrawSuare(int _length, int _width, int _pBoxWidth, int _pBoxHigh)
        {
            b = new Bitmap(_pBoxWidth, _pBoxHigh);
            p = new Pen(Color.Black, 3);

            line(Graphics.FromImage(b), p, 50, 0, _width * 50, 0);

            line(Graphics.FromImage(b), p, 50, 0, 50, _length * 50);
            line(Graphics.FromImage(b), p, _width * 50, 0, _width * 50, _length * 50);

            line(Graphics.FromImage(b), p, 50, _length * 50, _width * 50, _length * 50);
            return 0;
        }
    }
}