﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int dx = 1;
        int dy = 1;
        int x, y;
        public Form1()
        {
            InitializeComponent();
            x = label1.Location.X;
            y = label1.Location.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += dx;
            y += dy;
            if (x == 100)
                dx = -1;
            if (x == 0)
                dx = 1;
            if (y == 100)
                dy = -1;
            if (y == 0)
                dy = 1;
            label1.Location = new Point(x, y);
        }
    }
}
