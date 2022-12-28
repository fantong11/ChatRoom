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
        List<Room> rooms = new List<Room>();

        public ChatRoomClient(string url)
        {
            this.client = new WebSocket(url);
            rooms.Add(new Room("Lobby"));
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
        public List<Room> GetRooms()
        {
            return rooms;
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
            Console.WriteLine(e.Data);
            ReceiveData buffer = JsonSerializer.Deserialize<ReceiveData>(e.Data);
            
            switch (buffer.command) 
            {
                case 2:
                    Console.WriteLine("enter the case 2");
                    break;
                case 3:
                    subject.Notify(buffer);
                    break;
                case 5:
                    Room room = new Room(buffer.recipientName);
                    rooms.Add(room);

                    subject.ChangeRoom(buffer.recipientName);
                    // subject.ChangeRoom(room);

                    break;
                case 6:
                    Console.WriteLine(buffer.users);
                    List<User> usersList = JsonSerializer.Deserialize<List<User>>(buffer.users);
                    subject.UpdateUsers(usersList);
                    break;
                default:
                    Console.WriteLine(buffer.command);
                    break;
            }
        }

        public void OnClose(object sender, EventArgs e)
        {
            
        }

        public void Send(SendData sendData)
        {
            string jsonString = JsonSerializer.Serialize(sendData);
            this.client.Send(jsonString);
        }

        public void Close()
        {
            this.client.Close();
        }
    }
}
