using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DSpeckmann.Resolver
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient();
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("8.8.8.8"), 53); // Google DNS for test purposes

            var packet = new DNS.Packet();
            packet.Header.QdCount = 1;
            packet.QuestionSection.Add(new DNS.Question("www.google.com", DNS.QType.A));
            byte[] bytes = packet.GetBytes();
            Console.WriteLine("Packet created...");
            udpClient.Send(bytes, bytes.Length, endpoint);
            Console.WriteLine("Packet sent...");
            byte[] response = udpClient.Receive(ref endpoint);
            Console.WriteLine("Packet received...");

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(response));
            Console.ReadLine();
        }
    }
}