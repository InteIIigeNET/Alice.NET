using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class CardItemBuilder
	{
		private CardItem _cardItem;

		public CardItemBuilder Create(string title, string imageId)
		{
			_cardItem = new CardItem()
			{
				Title = title,
				ImageId = imageId
			};
			return this;
		}

		public CardItemBuilder WithDescription(string description)
		{
			_cardItem.Description = description;
			return this;
		}

		public CardItemBuilder WithButton(Button button)
		{
			_cardItem.Button = button;
			return this;
		}
	}
}