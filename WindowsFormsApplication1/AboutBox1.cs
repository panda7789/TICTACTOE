﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
