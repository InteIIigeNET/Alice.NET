namespace Alice.Models.Builders
{
	public interface IModelBuilder<out TModel>
	{
		TModel Build();
	}
}