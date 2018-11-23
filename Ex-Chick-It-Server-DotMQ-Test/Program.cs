using System;
using Gameplay;
using Google.Protobuf;
using NetMQ;
using NetMQ.Sockets;

namespace Ex_Chick_It_Server_NetMQ_Test
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var subscriber = new SubscriberSocket())
            using (var sender = new PushSocket())
            {
                Msg msg = new Msg();
                
                subscriber.Connect("tcp://localhost:40000");
                sender.Connect("tcp://localhost:40001");
                
                subscriber.SubscribeToAnyTopic();
                
                while (true)
                {                    

                    var eventPacket = new EventPacket();
                    eventPacket.Radius = 1;
                    eventPacket.Type = EventPacket.Types.ActionType.Attack;
                    eventPacket.SendTime = 1111;
                    eventPacket.SessionId = 12324;

                    msg.InitPool(eventPacket.CalculateSize());
                    var bytes = eventPacket.ToByteArray();
                    
                    msg.Put(bytes, 0, bytes.Length);
                    sender.Send(ref msg, false);
                    
                    msg.InitPool(eventPacket.CalculateSize());

                    subscriber.Receive(ref msg);

                    eventPacket = EventPacket.Parser.ParseFrom(msg.Data);
                    Console.WriteLine(eventPacket.ToString());
                }
            }
            
        }
    }
}