using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RackSharp
{
    public interface IRackResponse
    {
        void write(string content);
    }
}
