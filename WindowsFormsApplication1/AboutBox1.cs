using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    
    partial class AboutBox1 : Form
    {
        public Form1 form;
        public AboutBox1(Form1 frm)
        {
            form = frm;
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            
            form.barva_tl();
            
            if (form.pocet < 100)
            {
                Serv srv = new Serv();
                srv.Start(form);
            }
            else
            {
                while (true)
                {
                    try
                    {
                        Cli cli = new Cli();
                        cli.Connect(form);
                    }
                    catch { Thread.Sleep(3000); }


                }
            }
            this.Close();
        }
    }
}
