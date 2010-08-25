using System;
using System.Linq;
using System.Text;
using System.Web;

namespace RackSharp
{
    public interface IRack
    {
        Tuple<IRackStatus, IHeaderCollection, IBody> call(IRackEnvironment environment);
    }
}
