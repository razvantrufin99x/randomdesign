using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randomdesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Font f;
        Pen p;
        Brush b;
        Random r = new Random(1920);

        int lastx = 0;
        int lasty = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            this.Width = 1920;
            this.Height = 1080;
            g = this.CreateGraphics();
            f = Font;
            p = new Pen(Color.Black, 50);
            b = new SolidBrush(Color.Black);

        }
        Color RandomColor()
        {
            Random rand = new Random();
            return Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }
        public Color IntToColor(int argb)
        {
            return Color.FromArgb(argb);
        }
        public void drawRndColorLines()
        {
            for (int i = 0; i < 10000; i++)
            {
                int a = r.Next(0, 1920);
                int b = r.Next(0, 1920);
                // p.Color = IntToColor(r.Next(0, 1920));
                p.Color = RandomColor();
                //Color myColor = RandomColor();
                g.DrawLine(p, a, b, lastx, lasty);
                lastx = a;
                lasty = b;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            drawRndColorLines();
            drawRndColorLines();
            drawRndColorLines();
            drawRndColorLines();
            drawRndColorLines();
        }
    }
}
