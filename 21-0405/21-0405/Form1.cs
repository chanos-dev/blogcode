using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_0405
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = e.Graphics; 

            Rectangle rect = new Rectangle(25, 25, 100, 100);

            gp.DrawPie(Pens.Green, rect, 0, 90);
            gp.FillPie(Brushes.Green, rect, 0, 90);

            gp.DrawPie(Pens.Blue, rect, 180, 90);
            gp.FillPie(Brushes.Blue, rect, 180, 90);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;

            gp.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(25, 25, 100, 100);

            gp.DrawPie(Pens.Green, rect, 0, 90);
            gp.FillPie(Brushes.Green, rect, 0, 90);

            gp.DrawPie(Pens.Blue, rect, 180, 90);
            gp.FillPie(Brushes.Blue, rect, 180, 90); 
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;

            gp.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(25, 25, 100, 100);

            gp.DrawPie(Pens.Blue, rect, 0, 180);
            gp.FillPie(Brushes.Blue, rect, 0, 180);

            gp.DrawPie(Pens.Red, rect, 180, 180);
            gp.FillPie(Brushes.Red, rect, 180, 180);

            rect = new Rectangle(25, 50, 50, 50);

            gp.DrawPie(Pens.Red, rect, 0, 360);
            gp.FillPie(Brushes.Red, rect, 0, 360);

            rect = new Rectangle(75, 50, 50, 50);
            gp.DrawPie(Pens.Blue, rect, 180, 360);
            gp.FillPie(Brushes.Blue, rect, 180, 360);
        }
    }
}
