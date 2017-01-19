using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolver
{
    class DnsPacket
    {
        public short Id { get; set; }
        public bool Qr { get; set; }
        public int Opcode { get; set; } // TODO: Enum?
        public bool Aa { get; set; }
        public bool Tc { get; set; }
        public bool Rd { get; set; }
        public bool Ra { get; set; }
        public int Rcode { get; set; } // TODO: Enum?
        public short QdCount { get; set; }
        public short AnCount { get; set; }
        public short NsCount { get; set; }
        public short ArCount { get; set; }
        public List<DnsQuestion> QuestionSection { get; set; }
        public List<DnsAnswer> AnswerSection { get; set; }
        public List<DnsAuthority> AuthoritySection { get; set; }
        public List<DnsAdditional> AdditionalSection { get; set; }

        // TODO: Put header in extra class?
        // TODO: Constructor
        // TODO: DNS namespace
    }
}
