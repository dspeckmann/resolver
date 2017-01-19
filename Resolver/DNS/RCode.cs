using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.Resolver.DNS
{
    enum RCode
    {
        NoError = 0,
        FormErr = 1,
        ServFail = 2,
        NXDomain = 3,
        NotImp = 4,
        Refused = 5,
        YXDomain = 6,
        YXRRSet = 7,
        NotAuthoritive = 8,
        NotAuthorized = 9,
        NotZone = 10,
        BadVersOrSig = 16,
        BadSig = 17,
        BadKey = 17,
        BadTime = 18,
        BadMode = 19,
        BadName = 20,
        BadAlg = 21,
        BadTrunc = 22,
        BadCookie = 23
    }
}
