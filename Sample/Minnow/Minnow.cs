using System;
using Boat;

namespace Minnow
{
    public class Minnow : App
    {
        public Minnow(Context context)
            : base(context) 
        {
            get("/", index);
        }

        private void index(Context context)
        {
            this.Write("Hey Skipper");
        }
    }
}
