using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class ItemsListCardBuilder : CardBuilder<ItemsListCard>
	{
		public ItemsListCardBuilder Create(params CardItem[] cardItems)
		{
			Card = new ItemsListCard() {CardItems = cardItems};
			return this;
		}

		public ItemsListCardBuilder WithHeader(Header header)
		{
			Card.Header = header;
			return this;
		}

		public ItemsListCardBuilder WithFooter(Footer footer)
		{
			Card.Footer = footer;
			return this;
		}
	}
}