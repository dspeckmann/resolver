using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.Resolver.DNS
{
    // TODO: Better name?
    abstract class MessagePart
    {
        public abstract IEnumerable<Byte> GetBytes();

        protected IEnumerable<Byte> EncodeName(string name)
        {
            var bytes = new List<Byte>();
            var labels = name.Split(new[] { '.' });
            foreach(string label in labels)
            {
                bytes.Add((byte)ASCIIEncoding.ASCII.GetByteCount(label));
                bytes.AddRange(ASCIIEncoding.ASCII.GetBytes(label));
            }
            bytes.Add(0);

            return bytes.ToArray();
        }

        // DNS is always big-endian
        protected IEnumerable<Byte> ShortToBytes(short number)
        {
            IEnumerable<Byte> bytes = BitConverter.GetBytes(number);
            if (BitConverter.IsLittleEndian)
            {
                bytes = bytes.Reverse();
            }

            return bytes;
        }
    }
}
