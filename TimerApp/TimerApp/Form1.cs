using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        SolidBrush brush = new SolidBrush(Color.Red);
        int x = 100;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            if(x==300)
            timer1.Stop();
            //gfx.FillEllipse(brush, 20, 20, 100, 100);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            gfx.FillEllipse(brush, 20, 20, x, 100);
            x += 3;
        }
    }
}



