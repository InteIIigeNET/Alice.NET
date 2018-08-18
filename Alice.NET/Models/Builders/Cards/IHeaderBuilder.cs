using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public interface IHeaderBuilder : IModelBuilder<Header>
	{
		IHeaderBuilder Create(string text);
	}
}