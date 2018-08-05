using Newtonsoft.Json;

namespace Alice.JsonSerializer
{
	public class JsonSerializer : IJsonSerializer
	{
		private readonly JsonSerializerSettings _settings =
			new JsonSerializerSettings() {NullValueHandling = NullValueHandling.Ignore};

		public string Serialize<TModel>(TModel model)
		{
			return JsonConvert.SerializeObject(model, Formatting.None, _settings);
		}

		public TModel Deserialize<TModel>(string json)
		{
			return JsonConvert.DeserializeObject<TModel>(json);
		}
	}
}