using System;
using RackSharp;

namespace Boat
{
    public class Context
    {
        public IRackEnvironment Environment { get; set; }
        public Context(IRackEnvironment environmet)
        {
            Environment = environmet;
        }
    }
}
