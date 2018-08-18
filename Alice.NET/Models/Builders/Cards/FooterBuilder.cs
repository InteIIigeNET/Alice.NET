using System;
using Alice.Models.Builders.Buttons;
using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class FooterBuilder : BaseBuilder<Footer>, IFooterBuilder
	{
		private readonly IButtonBuilder<Button> _defaultButtonBuilder;

		public IFooterBuilder Create(string text)
		{
			BuildingModel = new Footer() {Text = text};
			return this;
		}

		public IFooterBuilder WithButton(Button button)
		{
			BuildingModel.Button = button;
			return this;
		}

		public IFooterBuilder WithButton(Func<IButtonBuilder<Button>, Button> buttonBuildFunc, 
										 IButtonBuilder<Button> builder = null)
		{
			builder = builder ?? _defaultButtonBuilder;
			BuildingModel.Button = buttonBuildFunc(builder);
			return this;
		}
	}
}