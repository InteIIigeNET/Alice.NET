using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class BigImageCardBuilder : CardBuilder<BigImageCard>
	{
		public BigImageCardBuilder Create(string title, string imageId)
		{
			Card = new BigImageCard()
			{
				Title = title,
				ImageId = imageId
			};
			return this;
		}

		public BigImageCardBuilder WithDescription(string description)
		{
			Card.Description = description;
			return this;
		}

		public BigImageCardBuilder WithButton(Button button)
		{
			Card.Button = button;
			return this;
		}
	}
}