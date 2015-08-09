using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public class Cli
    {
        Form1 frm;
        TcpClient tcpclnt = new TcpClient();
        public string a;
        public Cli()
        {
            
            
        }
        public void Connect(Form1 frma)
        {
            frm = frma;
            try
            {
                
                frm.settext("Connecting");
                string ip = frm.textBox1.Text.ToString();
                tcpclnt.Connect(ip, 8001);
                // use the ipaddress as in the server program
                frm.settext("Connected");

                    
                    

                
                
            }
            catch (Exception e)
            {
                frm.settext("Error..... " + e.StackTrace);
                frm.Show();
            }
        }
        public void Write(string st)
        {
                

                String str = st;
                Stream stm = tcpclnt.GetStream();

                ASCIIEncoding asen = new ASCIIEncoding();
                byte[] ba = asen.GetBytes(str);
                

                stm.Write(ba, 0, ba.Length);
        }
        public void Get()
        {
            try
            {
                Stream stm = tcpclnt.GetStream();
                byte[] bb = new byte[100];
                int k = stm.Read(bb, 0, 100);
                
                a = null;
                for (int i = 0; i < k; i++)
                {
                    Console.Write(Convert.ToChar(bb[i]));
                    a += Convert.ToChar(bb[i]);
                }
                if (a != null)
                {
                    Button btn = (Button)frm.Controls.Find(a, true)[0];
                    btn.BackColor = Color.Green;
                    try
                    {
                        btn.Enabled = false;
                    }
                    catch { }
                }

                
            }
            catch (IOException)
            {
                
            }

                
        }
        public void Disconnect()
        {
                            tcpclnt.Close();
        }


        }

    }
