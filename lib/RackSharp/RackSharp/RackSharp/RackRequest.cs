using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RackSharp
{
    public class RackRequest : IRackRequest
    {
        private HttpRequest _httpRequest;
        public RackRequest(HttpRequest httpRequest)
        {
            _httpRequest = httpRequest;
        }
    }
}
