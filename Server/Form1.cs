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

namespace Server
{
    struct Client_Info
    {
       public Socket clientSocket;
       public int CLientID;
    }
    public partial class ServerForm : Form
    {
        Socket serverSocket;
        List<Client_Info> clientList;
        byte[] buffer;
        int CLientID = 0;
        int tempID;
       

        public ServerForm()
        {
            InitializeComponent();
          
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientList = new List<Client_Info>();
            buffer = new byte[2048];
            serverSocket.Bind(new IPEndPoint(IPAddress.Loopback, 8000));
            serverSocket.Listen(5);

            CheckForIllegalCrossThreadCalls = false;
            Thread t2 = new Thread(Accept_Client);
            t2.Start();
        }
        public void Accept_Client()
        {
            while (true)
            {
                Socket newClient = serverSocket.Accept();
                CLientID++;
                Client_Info client = new Client_Info();
                client.clientSocket = newClient;
                client.CLientID = CLientID;
                clientList.Add(client);
                List_Clients.Items.Add("Client " + CLientID, CheckState.Unchecked);

                try
                {
                    foreach (Client_Info clientt in clientList)
                    {
                        clientt.clientSocket.Send(Encoding.ASCII.GetBytes("\nServer: Client " + CLientID + " connected\n"));
                    }
                }
                catch (Exception)
                {

                    string s = "do nothing";
                }
               
              
                
                Thread t = new Thread(new ThreadStart( () => ReadMessage(newClient)));
                t.Start();
            }
        }

        public void ReadMessage(Socket client)
        {
            try
            {
                while (true)
                {

                    Client_Info[] ci = clientList.ToArray();
                    int index = 0;
                    foreach (Client_Info currentClient in ci)
                    {

                        if (client == currentClient.clientSocket)
                        {
                            buffer = new byte[1024];
                            int len = client.Receive(buffer);
                            string msg = Encoding.ASCII.GetString(buffer);
                            txtMsgRecieve.Text += "Client " + currentClient.CLientID + ": " + msg + "\n";
                            if (msg == "Close\n")
                            {
                                List_Clients.Items.RemoveAt(index); //i dont know why this elemnt not removing from checkbox list
                                clientList.Remove(currentClient);
                               
                            }
                        }
                        index++;
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show("One Client Disconected");
            }
          

        }


     
        private void btnSend_Click(object sender, EventArgs e)
        {
            
            foreach (Client_Info client in clientList)
            {
                client.clientSocket.Send(Encoding.ASCII.GetBytes("Server: "+txtMsg.Text+"\n"));
            }
        }

        private void btn_Send_Selected_Click(object sender, EventArgs e)
        {

            foreach (Client_Info client in clientList)
            {
                if (tempID == client.CLientID)
                {
                    client.clientSocket.Send(Encoding.ASCII.GetBytes("Server: " + txtMsg.Text + "\n"));
                }
            }
            
            for (int i = 0; i < List_Clients.Items.Count; i++)
            {
                List_Clients.SetItemChecked(i, false);
            }

        }

        private void List_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempID = int.Parse(List_Clients.Text.Split(' ')[1]);
        }
    }
}
