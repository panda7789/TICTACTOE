﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Cli client;
        Serv serv = new Serv();
        public int pocet = 0;
        public int[] pole = new int[9];
        public Button[] tlacitka = new Button[9];
        public Form1()
        {
            InitializeComponent();
            client  =new Cli();

            
            for (int i = 1; i < 10; i++)
            {
                Button btn = (Button)this.Controls.Find("button"+i, true)[0];
                tlacitka[i-1] = btn;
            }
            barva_tl();
            


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (client.muzes == true || serv.muzes == true)
            {
                Button btn = (Button)sender;
                if (pocet < 100)
                {

                    btn.BackColor = Color.Green;

                    if (pocet % 2 == 1)
                    {
                        label2.Text = "";
                        label1.Text = "HRAJEŠ";
                    }
                    else { label2.Text = "HRAJEŠ"; label1.Text = ""; }
                    serv.Send(btn.Name);
                    btn.Enabled = false;
                    Thread main = Thread.CurrentThread;
                    Thread t1 = new Thread(serv.Listen);

                    t1.Start();
                    Debug.Write(Thread.CurrentThread.ThreadState);
                    t1.Join();
                    Debug.Write(Thread.CurrentThread.ThreadState);







                }
                else if (pocet > 100)
                {

                    btn.BackColor = Color.Red;

                    client.Write(btn.Name);
                    btn.Enabled = false;

                    Thread main = Thread.CurrentThread;
                    Thread t1 = new Thread(client.Get);
                    t1.Start();

                    t1.Join();


                }

                pocet++;
                cekni();


            }
        }
        public void cekni()
        {
            AboutBox1 usr = new AboutBox1(this);

            #region 123
            if (new[] { button1.BackColor.ToArgb(), button2.BackColor.ToArgb(), button3.BackColor.ToArgb() }.All(x => x == button1.BackColor.ToArgb()))
            {
                if (button1.BackColor == Color.Red)
                {
                    
                    usr.label1.Text = "Vyhrál H2";
                    usr.label1.BackColor = Color.Red;
                    usr.label1.Visible = true; usr.Show();
                }
                else if (button1.BackColor == Color.Green)
                {
                    usr.label1.Text = "Vyhrál H1";
                    usr.label1.BackColor = Color.Green;
                    usr.label1.Visible = true; usr.Show(); 
                    
                }
            }
            #endregion
            #region 456
            else if (new[] { button4.BackColor.ToArgb(), button5.BackColor.ToArgb(), button6.BackColor.ToArgb() }.All(x => x == button4.BackColor.ToArgb()))
            {
                if (button4.BackColor == Color.Red)
                {
                    usr.label1.Text = "Vyhrál H2";
                    usr.label1.BackColor = Color.Red;
                    usr.label1.Visible = true; usr.Show();  
                }
                else if (button4.BackColor == Color.Green)
                {
                    usr.label1.Text = "Vyhrál H1";
                    usr.label1.BackColor = Color.Green;
                    usr.label1.Visible = true; usr.Show();  
                }
                else { usr.label1.Text = "FUCK"; }
                
            }
            #endregion
            #region 789
            else if (new[] { button7.BackColor.ToArgb(), button8.BackColor.ToArgb(), button9.BackColor.ToArgb() }.All(x => x == button7.BackColor.ToArgb()))
            {
                if (button7.BackColor == Color.Red)
                {
                    usr.label1.Text = "Vyhrál H2";
                    usr.label1.BackColor = Color.Red;
                    usr.label1.Visible = true; usr.Show();  
                }
                else if (button7.BackColor == Color.Green)
                {
                    usr.label1.Text = "Vyhrál H1";
                    usr.label1.BackColor = Color.Green;
                    usr.label1.Visible = true; usr.Show();  
                }
            }
            #endregion
            #region 147
            else if (new[] { button1.BackColor.ToArgb(), button4.BackColor.ToArgb(), button7.BackColor.ToArgb() }.All(x => x == button1.BackColor.ToArgb()))
            {
                if (button1.BackColor == Color.Red)
                {
                    usr.label1.Text = "Vyhrál H2";
                    usr.label1.BackColor = Color.Red;
                    usr.label1.Visible = true; usr.Show();  
                }
                else if (button1.BackColor == Color.Green)
                {
                    usr.label1.Text = "Vyhrál H1";
                    usr.label1.BackColor = Color.Green;
                    usr.label1.Visible = true; usr.Show();  
                }
            }
            #endregion
            #region 258
            else if (new[] { button2.BackColor.ToArgb(), button5.BackColor.ToArgb(), button8.BackColor.ToArgb() }.All(x => x == button2.BackColor.ToArgb()))
            {
                if (button2.BackColor == Color.Red)
                {
                    usr.label1.Text = "Vyhrál H2";
                    usr.label1.BackColor = Color.Red;
                    usr.label1.Visible = true; usr.Show();  
                }
                else if (button2.BackColor == Color.Green)
                {
                    usr.label1.Text = "Vyhrál H1";
                    usr.label1.BackColor = Color.Green;
                    usr.label1.Visible = true; usr.Show();  
                }
            }
            #endregion
            #region 369
            else if (new[] { button3.BackColor.ToArgb(), button6.BackColor.ToArgb(), button9.BackColor.ToArgb() }.All(x => x == button3.BackColor.ToArgb()))
            {
                if (button3.BackColor == Color.Red)
                {
                    usr.label1.Text = "Vyhrál H2";
                    usr.label1.BackColor = Color.Red;
                    usr.label1.Visible = true; usr.Show();  
                }
                else if (button3.BackColor == Color.Green)
                {
                    usr.label1.Text = "Vyhrál H1";
                    usr.label1.BackColor = Color.Green;
                    usr.label1.Visible = true; usr.Show();  
                }
            }
            #endregion
            #region 159
            else if (new[] { button1.BackColor.ToArgb(), button5.BackColor.ToArgb(), button9.BackColor.ToArgb() }.All(x => x == button1.BackColor.ToArgb()))
            {
                if (button1.BackColor == Color.Red)
                {
                    usr.label1.Text = "Vyhrál H2";
                    usr.label1.BackColor = Color.Red;
                    usr.label1.Visible = true; usr.Show();  
                }
                else if (button1.BackColor == Color.Green)
                {
                    usr.label1.Text = "Vyhrál H1";
                    usr.label1.BackColor = Color.Green;
                    usr.label1.Visible = true; usr.Show();  
                }
            }
            #endregion
            #region 357
            else if (new[] { button3.BackColor.ToArgb(), button5.BackColor.ToArgb(), button7.BackColor.ToArgb() }.All(x => x == button3.BackColor.ToArgb()))
            {
                if (button3.BackColor == Color.Red)
                {
                    usr.label1.Text = "Vyhrál H2";
                    usr.label1.BackColor = Color.Red;
                    usr.label1.Visible = true; usr.Show();  
                }
                else if (button3.BackColor == Color.Green)
                {
                    usr.label1.Text = "Vyhrál H1";
                    usr.label1.BackColor = Color.Green;
                    usr.label1.Visible = true; usr.Show();  
                }
            }
            #endregion
            #region tied
            else if (button1.Enabled==false){
                if(button2.Enabled==false){
                    if(button3.Enabled==false){
                        if(button4.Enabled==false){
                            if(button5.Enabled==false){
                                if(button6.Enabled==false){
                                    if(button7.Enabled==false){
                                        if(button8.Enabled==false){
                                            if(button9.Enabled==false){
                                                                    usr.label1.Text = "Remíza";
                                                                    usr.label1.BackColor = Color.AliceBlue;
                                                                    usr.label1.Visible = true; 
                                                                    usr.Show(); 
                                                                    this.Enabled = false; 
                                                                    try{ serv.Stop();} catch{client.Disconnect();} 
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            

            }
            #endregion


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason == CloseReason.UserClosing) || (e.CloseReason == CloseReason.ApplicationExitCall))
            {

                Application.ExitThread();


            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ukaz();
            button11.Visible = false;
            client.Connect(this);
            pocet += 101;
            
        }
        public void settext(string text)
        {
            debug.Text = text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pocet = 1;
            button10.Visible = false;
            ukaz();
            serv.Start(this);
            serv.Listen();
            
        }

        public void schov()
        {
            for (int i = 1; i < 10; i++)
            {
                Button btn = (Button)this.Controls.Find("button" + i.ToString(), true)[0];
                btn.Enabled = false;
            }
        }
        public void ukaz()
        {
            for (int i = 1; i < 10; i++)
            {
                Button btn = (Button)this.Controls.Find("button" + i.ToString(), true)[0];
                btn.Enabled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            serv.Listen();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            client.Get();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            textBox1.Text = myIP.ToString() ;
        }
        public void hrajes()
        {
            if (pocet < 100)
            {
                if (pocet % 2 == 0)
                {
                    this.Invoke((MethodInvoker)(() => label2.Text = ""));
                    this.Invoke((MethodInvoker)(() => label1.Text = "HRAJEŠ"));
                }
                else
                {
                    this.Invoke((MethodInvoker)(() => label2.Text = "HRAJEŠ"));
                    this.Invoke((MethodInvoker)(() => label1.Text = ""));
                }
            }
            else if (pocet > 101)
            {
                if (pocet % 2 == 1)
                {
                    this.Invoke((MethodInvoker)(() => label2.Text = ""));
                    this.Invoke((MethodInvoker)(() => label1.Text = "HRAJEŠ"));
                }
                else
                {
                    this.Invoke((MethodInvoker)(() => label2.Text = "HRAJEŠ"));
                    this.Invoke((MethodInvoker)(() => label1.Text = ""));
                }
            }
        }

        private void button7_BackColorChanged(object sender, EventArgs e)
        {
            

        }
        public void barva_tl()
        {
            foreach(Button tlac in tlacitka){
                tlac.BackColor = Color.FromArgb(224, 224, 224);
                tlac.Enabled = true;
            }
            tlacitka[0].BackColor = Color.FromArgb(224, 224, 225);
            tlacitka[1].BackColor = Color.FromArgb(224, 225, 224);
            tlacitka[2].BackColor = Color.FromArgb(225, 224, 224);
            tlacitka[3].BackColor = Color.FromArgb(224, 224, 223);
            tlacitka[6].BackColor = Color.FromArgb(224, 223, 224);

        }









    }
}
