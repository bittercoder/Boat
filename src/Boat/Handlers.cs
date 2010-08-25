using System;

namespace Boat
{
    public interface IHandler
    {
        string Route { get; set; }
        Action<Context> Handler { get; set; }
    }

    public class GetHandler : IHandler
    {
        public string Route { get; set; }
        public Action<Context> Handler { get; set; }
    }

    public class PutHandler : IHandler
    {
        public string Route { get; set; }
        public Action<Context> Handler { get; set; }
    }

    public class DeleteHandler : IHandler
    {
        public string Route { get; set; }
        public Action<Context> Handler { get; set; }
    }

    public class PostHandler : IHandler
    {
        public string Route { get; set; }
        public Action<Context> Handler { get; set; }
    }
}