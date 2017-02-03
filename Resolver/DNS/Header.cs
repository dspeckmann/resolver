using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.Resolver.DNS
{
    class Header : MessagePart
    {
        private static short id = 0; // TODO: Random number?
        public short ID { get; set; } = id++;
        public bool QR { get; set; } = true; // QR = 0 means query, 1 means response
        public OpCode OpCode { get; set; } = OpCode.Query;
        public bool AA { get; set; } = false;
        public bool TC { get; set; } = false;
        public bool RD { get; set; } = true;
        public bool RA { get; set; } = false;
        public RCode RCode { get; set; } = RCode.NoError;
        public short QdCount { get; set; } = 0;
        public short AnCount { get; set; } = 0;
        public short NsCount { get; set; } = 0;
        public short ArCount { get; set; } = 0;

        public override IEnumerable<Byte> GetBytes()
        {
            var bytes = new List<Byte>();
            bytes.AddRange(ShortToBytes(ID));
            byte[] flags = new byte[] {
                1,      // QR, OPCODE, AA, TC, RD (129 = Query and Recursion Desired)
                0,      // RA, RCODE
            };
            bytes.AddRange(flags);
            bytes.AddRange(ShortToBytes(QdCount));
            bytes.AddRange(ShortToBytes(AnCount));
            bytes.AddRange(ShortToBytes(NsCount));
            bytes.AddRange(ShortToBytes(ArCount));
            return bytes;
        }
    }
}
