using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RackSharp
{
    public interface IRackEnvironment
    {
        IRackRequest Request { get; set; }
        IRackResponse Response { get; set; }

    }
}
