using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.Resolver.DNS
{
    class Question : MessagePart
    {
        public string QName { get; set; }
        public QType QType { get; set; } = QType.A;
        public QClass QClass { get; set; } = QClass.IN;

        public Question(string qname, QType qtype, QClass qclass = QClass.IN)
        {
            QName = qname;
            QType = qtype;
            QClass = qclass;
        }

        public override IEnumerable<Byte> GetBytes()
        {
            var bytes = new List<Byte>();
            bytes.AddRange(EncodeName(QName));
            bytes.AddRange(ShortToBytes((short)QType));
            bytes.AddRange(ShortToBytes((short)QClass));
            return bytes;
        }
    }
}
