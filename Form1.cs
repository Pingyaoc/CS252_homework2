using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS252_homework2
{
    public partial class Form1 : Form
    {
        private DrawSquare Square;
        //     private Pen p;
        //     private Bitmap b;

        public Form1()
        {
            InitializeComponent();
        }

        private void DrawSquareButton1_Click(object sender, EventArgs e)
        {
            int pBoxWidth, pBoxHeigh;
            pBoxWidth = pictureBox1.Width;
            pBoxHeigh = pictureBox1.Height;

            int tlength = int.Parse(SquareLengthTextBox1.Text);
            int twidth = int.Parse(SquareWidthTextBox2.Text);
            Square = new DrawSquare();
            Square.Length = tlength;
            Square.Width = twidth;
            Square.UserDrawSuare(Square.Length, Square.Width, pBoxWidth, pBoxHeigh);
            pictureBox1.Image = Square.b;
        }
    }
}