using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class HeaderBuilder : BaseBuilder<Header>, IHeaderBuilder
	{
		public IHeaderBuilder Create(string text)
		{
			BuildingModel = new Header()
			{
				Text = text
			};
			return this;
		}
	}
}