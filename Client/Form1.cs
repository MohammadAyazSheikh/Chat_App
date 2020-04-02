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
using System.Threading;

namespace Client
{
    public partial class ClientForm : Form
    {
        Socket ClientSocket; 
        public ClientForm()
        {
            InitializeComponent();
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ClientSocket.Connect(IPAddress.Loopback, 8000);
            byte[] buffer = Encoding.ASCII.GetBytes("client connected\n");
            ClientSocket.Send(buffer);
            Thread t2 = new Thread(RecieveMsg);
            t2.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(txtMsg.Text+"\n");
            ClientSocket.Send(buffer);
        }

        public void RecieveMsg()
        {
            try
            {
                while (true)
                {
                    var buffer = new byte[1024];
                    int len = ClientSocket.Receive(buffer, SocketFlags.None);
                    txtRecieve.Text += Encoding.ASCII.GetString(buffer);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Client Goes Down");
            }
           
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.ASCII.GetBytes("Close\n");
            ClientSocket.Send(buffer);
            ClientSocket.Close();
            Close();
        }
    }
}
