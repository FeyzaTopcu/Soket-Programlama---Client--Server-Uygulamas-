using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public string TexttoSend;

        public Form1()
        {
            InitializeComponent();

            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach( IPAddress address in localIP)
            {
                if(address.AddressFamily == AddressFamily.InterNetwork)
                {
                    txt1.Text = address.ToString();

                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, int.Parse(txt2.Text));
            listener.Start();
            client = listener.AcceptTcpClient();
            STR = new StreamReader(client.GetStream());
            STW = new StreamWriter(client.GetStream());
            STW.AutoFlush = true;
            backgroundWorker1.RunWorkerAsync();
            backgroundWorker2.WorkerSupportsCancellation = true;

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            IPEndPoint IPEnd = new IPEndPoint(IPAddress.Parse(txt3.Text), int.Parse(txt4.Text));

            try
            {
                client.Connect(IPEnd);
                if(client.Connected)
                {
                    txt5.AppendText(" Connected Server" + "\n");
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;

                }
            }
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while( client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.txt5.Invoke(new MethodInvoker(delegate()
                    {
                        txt5.AppendText(" You :" + recieve + "\n");

                    }));
                    recieve = "";

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if(client.Connected)
            {
                STW.WriteLine ( TexttoSend);
                this.txt5.Invoke(new MethodInvoker(delegate ()
               {
                    txt5.AppendText("Me:" + TexttoSend + "\n");
               }));
            }
            else
            {
                MessageBox.Show("Sending Failed ");
                backgroundWorker2.CancelAsync();
            }
                    
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if(txt6.Text != "")
            {
                TexttoSend = txt6.Text;
                backgroundWorker2.RunWorkerAsync();
          
            }
            txt6.Text = "";
        }

        }
    }

