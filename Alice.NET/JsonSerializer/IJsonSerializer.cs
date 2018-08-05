namespace Alice.JsonSerializer
{
	public interface IJsonSerializer
	{
		string Serialize<TModel>(TModel model);
		TModel Deserialize<TModel>(string json);
	}
}