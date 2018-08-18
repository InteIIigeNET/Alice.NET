using System;
using Alice.Models.Builders.Buttons;
using Alice.Models.Buttons;

namespace Alice.Models.Builders.Cards
{
	public interface IImageCardBuilder
	{
		IImageCardBuilder Create(string title, string imageId);
		IImageCardBuilder WithButton(Button button);
		IImageCardBuilder WithButton(Func<IButtonBuilder<Button>, Button> buttonBuildFunc,
										IButtonBuilder<Button> builder = null);
		IImageCardBuilder WithDescription(string description);
	}
}