namespace Alice.Models.Builders
{
	public class BaseBuilder<TModel> : IModelBuilder<TModel>
	{
		protected TModel BuildingModel;
		public TModel Build()
		{
			return BuildingModel;
		}
	}
}