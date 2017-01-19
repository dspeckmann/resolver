using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSpeckmann.Resolver.DNS
{
    enum OpCode
    {
        Query = 0,
        IQuery = 1,
        Status = 2,
        Notify = 4,
        Update = 5
    }
}
