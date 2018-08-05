using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class ItemsListCardBuilder : CardBuilder<ItemsListCard>
	{
		public CardBuilder<ItemsListCard> Create(params CardItem[] cardItems)
		{
			Card = new ItemsListCard() {CardItems = cardItems};
			return this;
		}

		public CardBuilder<ItemsListCard> WithHeader(Header header)
		{
			Card.Header = header;
			return this;
		}

		public CardBuilder<ItemsListCard> WithFooter(Footer footer)
		{
			Card.Footer = footer;
			return this;
		}
	}
}