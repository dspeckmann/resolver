using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.Resolver.DNS
{
    class Header
    {
        public short Id { get; set; }
        public bool Qr { get; set; }
        public OpCode OpCode { get; set; } // TODO: Enum?
        public bool Aa { get; set; }
        public bool Tc { get; set; }
        public bool Rd { get; set; }
        public bool Ra { get; set; }
        public RCode RCode { get; set; } // TODO: Enum?
        public short QdCount { get; set; }
        public short AnCount { get; set; }
        public short NsCount { get; set; }
        public short ArCount { get; set; }
    }
}
