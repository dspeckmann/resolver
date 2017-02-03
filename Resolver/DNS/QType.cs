using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.Resolver.DNS
{
    enum QType
    {
        A = 1,
        NS = 2,
        CNAME = 5,
        SOA = 6,
        WKS = 11,
        PTR = 12,
        MX = 15,
        AAAA = 28,
        SRV = 33,
        ANY = 255
    }
}
