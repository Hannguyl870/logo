using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen redpen = new Pen(Color.Red, 10);
            Pen Goldpen = new Pen(Color.Gold, 10);
            Pen Navypen = new Pen(Color.Navy, 10);
            Pen Whitepen = new Pen(Color.White, 10);
            SolidBrush Goldbrush = new SolidBrush(Color.Gold);
            SolidBrush Whitebrush = new SolidBrush(Color.White);

            g.Clear(Color.White);

            g.DrawArc(Navypen, 80, 20, 200, 200, 4, 270);

            g.DrawEllipse(Goldpen, 100, 50, 150, 156);
            g.FillEllipse(Goldbrush, 100, 50, 150, 156);

            g.DrawRectangle(Whitepen, 100,100,150, 50);
            g.FillRectangle(Whitebrush,100,100,150,50);

            Font drawFont = new Font("flame", 20, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.DrawString("BURGER \n KING", drawFont, drawBrush, 100,100);


        }

       
    }
}
