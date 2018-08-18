using System;
using Alice.Models.Builders.Responses;
using Alice.Models.Common;
using Alice.Models.Responses;

namespace Alice.Models.Builders.Common
{
	public class AliceResponseBuilder : BaseBuilder<AliceResponse>, IAliceResponseBuilder
	{
		private readonly IResponseBuilder _defaultResponseBuilder;

		public IAliceResponseBuilder Create(Response response)
		{
			BuildingModel = new AliceResponse {Response = response};
			return this;
		}

		public IAliceResponseBuilder Create(Func<IResponseBuilder, Response> responseBuildFunc,
										   IResponseBuilder builder = null)
		{
			builder = builder ?? _defaultResponseBuilder;
			BuildingModel.Response = responseBuildFunc(builder);
			return this;
		}

		public IAliceResponseBuilder ForSession(Session session)
		{
			BuildingModel.Session = session;
			return this;
		}

		public IAliceResponseBuilder UseProtocolVersion(string version)
		{
			BuildingModel.Version = version;
			return this;
		}
	}
}