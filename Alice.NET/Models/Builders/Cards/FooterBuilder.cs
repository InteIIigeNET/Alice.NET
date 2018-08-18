using System;
using Alice.Models.Builders.Buttons;
using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class FooterBuilder : IFooterBuilder
	{
		private Footer _footer;
		private readonly IButtonBuilder<Button> _defaultButtonBuilder;

		public IFooterBuilder Create(string text)
		{
			_footer = new Footer() {Text = text};
			return this;
		}

		public IFooterBuilder WithButton(Button button)
		{
			_footer.Button = button;
			return this;
		}

		public IFooterBuilder WithButton(Func<IButtonBuilder<Button>, Button> buttonBuildFunc, 
										 IButtonBuilder<Button> builder = null)
		{
			builder = builder ?? _defaultButtonBuilder;
			_footer.Button = buttonBuildFunc(builder);
			return this;
		}

		public Footer Build()
		{
			return _footer;
		}
	}
}