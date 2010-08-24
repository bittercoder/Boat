using System;
using System.Web;

namespace RackSharp
{
    public class RackResponse : IRackResponse
    {
        private HttpResponse _httpResponse;
        public RackResponse(HttpResponse httpResponse)
        {
            _httpResponse = httpResponse;
        }

        public void write(string content)
        {

        }
    }
}
