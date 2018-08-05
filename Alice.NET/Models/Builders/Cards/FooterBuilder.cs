using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class FooterBuilder
	{
		private Footer _footer;

		public FooterBuilder Create(string text)
		{
			_footer = new Footer()
			{
				Text = text
			};
			return this;
		}

		public FooterBuilder WithButton(Button button)
		{
			_footer.Button = button;
			return this;
		}

		public Footer Build()
		{
			return _footer;
		}
	}
}