using System.Collections.Generic;

namespace RackSharp
{
	public interface IBody
	{
		IEnumerable<object> GetContents();
		string Path { get; }
	}
}