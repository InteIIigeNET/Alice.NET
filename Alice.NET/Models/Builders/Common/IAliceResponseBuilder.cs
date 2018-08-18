using System;
using Alice.Models.Builders.Responses;
using Alice.Models.Common;
using Alice.Models.Responses;

namespace Alice.Models.Builders.Common
{
	public interface IAliceResponseBuilder
	{
		IAliceResponseBuilder Create(Response response);
		IAliceResponseBuilder Create(Func<IResponseBuilder, Response> responseBuildFunc, 
								     IResponseBuilder builder = null);
		IAliceResponseBuilder ForSession(Session session);
		IAliceResponseBuilder UseProtocolVersion(string version);
	}
}