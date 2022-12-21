using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using WebSocketSharp;
using System.Text.Json;
using System.Windows.Forms;

namespace ChatRoom
{
    public class ChatRoomClient
    {
        WebSocket client;
        string username;
        Subject subject;

        public ChatRoomClient(string url)
        {
            this.client = new WebSocket(url);
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }
        public string GetUsername()
        {
            return username;
        }
        public void SetSubject(Subject subject)
        {
            this.subject = subject;
        }

        public void Connect()
        {
            this.client.OnOpen += this.OnOpen;

            this.client.OnMessage += this.OnMessage;

            this.client.OnClose += this.OnClose;

            this.client.Connect();

        }

        public void OnOpen(object sender, EventArgs e)
        {

        }

        public void OnMessage(object sender, MessageEventArgs e)
        {
            ReceiveData buffer = JsonSerializer.Deserialize<ReceiveData>(e.Data);
            Console.WriteLine(buffer.username);
            Console.WriteLine(buffer.message);
            subject.Notify(buffer);
        }

        public void OnClose(object sender, EventArgs e)
        {
            
        }

        public void Send(SendData sendData)
        {
            string jsonString = JsonSerializer.Serialize(sendData);
            //Console.WriteLine(jsonString);
            this.client.Send(jsonString);
        }

        public void Close()
        {
            this.client.Close();
        }
    }
}
