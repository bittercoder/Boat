using System;
using System.Collections.Generic;
using RackSharp;

namespace Boat
{
    public class App : IRack
    {
        private Context _context = null;
        private List<IHandler> _getHandlers = null;
        private List<IHandler> _postHandlers = null;
        private List<IHandler> _putHandlers = null;
        private List<IHandler> _deleteHandlers = null;
        
        public App(Context context)
        {
            _context = context;            
        }

        public Context Context { get { return _context; } }

        public void get(string route, Action<Context> handler)
        {
            _getHandlers.Add(new GetHandler { Route=route, Handler = handler});
        }

        public void get(Func<string> route, Action<Context> handler)
        {
           get(route(), handler);
        }

        #region IRack Members

				public Tuple<IRackStatus, IHeaderCollection, IBody> call(IRackEnvironment environment)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    public static class AppExtensions
    {
        public static void Write(this App app, string  output)
        {
            app.Context.Environment.Response.write(output);
        }
    }
}
