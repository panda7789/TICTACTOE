using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Serv
    {
        TcpListener myList;
        Socket s;
        Form1 frm;
        public bool muzes;
        public void Start(Form1 form)
        {
            try
            {
                frm = form;
                string ip = frm.textBox1.Text.ToString();
                IPAddress ipAd = IPAddress.Parse(ip);
                // use local m/c IP address, and 
                // use the same in the client

                /* Initializes the Listener */
                myList = new TcpListener(ipAd, 8001);

                /* Start Listeneting at the specified port */
                myList.Start();
                s = myList.AcceptSocket();
                muzes = true;
            }
            catch { }
        }
        public void Listen()
        {
            if (muzes == true)
            {
                string a = null;
                byte[] b = new byte[100];


                int k = s.Receive(b);

                for (int i = 0; i < k; i++)
                    a += (Convert.ToChar(b[i])).ToString();
                //frm.debug.Text = a;
                if (a != null)
                {
                    Button btn = (Button)frm.Controls.Find(a, true)[0];
                    btn.BackColor = Color.Red;
                    
                    try
                    {
                        btn.Enabled = false;
                    }
                    catch { }

                }
            }
                
        }
        public void Send(string papa){


                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes(papa));
                Console.WriteLine("\nSent Acknowledgement");
        }
        public void Stop(){
                /* clean up */
                s.Close();
                myList.Stop();
        }




    }
}
