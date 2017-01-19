using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Resolver
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             *      Ugly prototype:
             * 
             */

            /* 
            UdpClient udpClient = new UdpClient();
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("8.8.8.8"), 53);

            byte[] header = new byte[] {
                123,      // Message ID
                123,      
                1,      // QR, OPCODE, AA, TC, RD
                0,      // RA, RCODE
                0,      // QDCOUNT
                1,      
                0,      // ANCOUNT
                0,     
                0,      // NSCOUNT 
                0,     
                0,      // ARCOUNT
                0
            };

            byte[] qname1length = new byte[] { (byte)ASCIIEncoding.ASCII.GetByteCount("google") };
            byte[] qname1 = ASCIIEncoding.ASCII.GetBytes("google");
            byte[] qname2length = new byte[] { (byte)ASCIIEncoding.ASCII.GetByteCount("com") };
            byte[] qname2 = ASCIIEncoding.ASCII.GetBytes("com");
            byte[] termination = new byte[] { 0 };
            byte[] qtype = new byte[] { 0, 1 };
            byte[] qclass = new byte[] { 0, 1 };

            byte[] packet = new byte[header.Length + qname1length.Length + qname1.Length + qname2length.Length + qname2.Length + termination.Length + qtype.Length + qclass.Length];
            Array.Copy(header, packet, header.Length);
            Array.Copy(qname1length, 0, packet, header.Length, qname1length.Length);
            Array.Copy(qname1, 0, packet, header.Length + qname1length.Length, qname1.Length);
            Array.Copy(qname2length, 0, packet, header.Length + qname1length.Length + qname1.Length, qname2length.Length);
            Array.Copy(qname2, 0, packet, header.Length + qname1length.Length + qname1.Length + qname2length.Length, qname2.Length);
            Array.Copy(termination, 0, packet, header.Length + qname1length.Length + qname1.Length + qname2length.Length + qname2.Length, termination.Length);
            Array.Copy(qtype, 0, packet, header.Length + qname1length.Length + qname1.Length + qname2length.Length + qname2.Length + termination.Length, qtype.Length);
            Array.Copy(qclass, 0, packet, header.Length + qname1length.Length + qname1.Length + qname2length.Length + qname2.Length + termination.Length + qtype.Length, qclass.Length);

            Console.WriteLine("Packet created");

            udpClient.Send(packet, packet.Length, endpoint);
            byte[] response = udpClient.Receive(ref endpoint);

            Console.WriteLine(ASCIIEncoding.ASCII.GetString(response));

            Console.WriteLine("Hello World!");
            Console.ReadLine();
            */
        }
    }
}
