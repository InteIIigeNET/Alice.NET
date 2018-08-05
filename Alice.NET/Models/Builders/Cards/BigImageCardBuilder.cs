using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class BigImageCardBuilder : CardBuilder<BigImageCard>
	{
		public CardBuilder<BigImageCard> Create(string title, string imageId)
		{
			Card = new BigImageCard()
			{
				Title = title,
				ImageId = imageId
			};
			return this;
		}

		public CardBuilder<BigImageCard> WithDescription(string description)
		{
			Card.Description = description;
			return this;
		}

		public CardBuilder<BigImageCard> WithButton(Button button)
		{
			Card.Button = button;
			return this;
		}
	}
}