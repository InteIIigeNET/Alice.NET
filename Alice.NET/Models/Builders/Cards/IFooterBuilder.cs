using System;
using Alice.Models.Builders.Buttons;
using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public interface IFooterBuilder : IModelBuilder<Footer>
	{
		IFooterBuilder Create(string text);
		IFooterBuilder WithButton(Button button);
		IFooterBuilder WithButton(Func<IButtonBuilder<Button>, Button> buttonBuilFunc,
								  IButtonBuilder<Button> builder = null);
	}
}