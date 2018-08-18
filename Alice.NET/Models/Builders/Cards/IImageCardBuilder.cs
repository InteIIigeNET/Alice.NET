using System;
using Alice.Models.Builders.Buttons;
using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public interface IImageCardBuilder : IModelBuilder<ImageCard>
	{
		IImageCardBuilder Create(string title, string imageId);
		IImageCardBuilder WithButton(Button button);
		IImageCardBuilder WithButton(Func<IButtonBuilder<Button>, Button> buttonBuildFunc,
										IButtonBuilder<Button> builder = null);
		IImageCardBuilder WithDescription(string description);
	}
}