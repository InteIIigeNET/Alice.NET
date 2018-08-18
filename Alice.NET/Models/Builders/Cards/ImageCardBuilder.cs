using System;
using Alice.Models.Builders.Buttons;
using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class ImageCardBuilder : CardBuilder<ImageCard>, IImageCardBuilder
	{
		private readonly IButtonBuilder<Button> _defaultButtonBuilder; //нужно инжектить
		public virtual IImageCardBuilder Create(string title, string imageId)
		{
			Card = new ImageCard(isBigImageCard: false)
			{
				Title = title,
				ImageId = imageId
			};
			return this;
		}

		public IImageCardBuilder WithDescription(string description)
		{
			Card.Description = description;
			return this;
		}

		public IImageCardBuilder WithButton(Button button)
		{
			Card.Button = button;
			return this;
		}

		public IImageCardBuilder WithButton(Func<IButtonBuilder<Button>, Button> buttonBuildFunc,
			IButtonBuilder<Button> builder = null)
		{
			builder = builder ?? _defaultButtonBuilder;
			Card.Button = buttonBuildFunc(builder);
			return this;
		}
	}
}