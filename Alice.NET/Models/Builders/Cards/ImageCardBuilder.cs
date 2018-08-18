using System;
using Alice.Models.Builders.Buttons;
using Alice.Models.Buttons;
using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public class ImageCardBuilder : BaseBuilder<ImageCard>, IImageCardBuilder
	{
		private readonly IButtonBuilder<Button> _defaultButtonBuilder; //нужно инжектить
		public virtual IImageCardBuilder Create(string title, string imageId)
		{
			BuildingModel = new ImageCard(isBigImageCard: false)
			{
				Title = title,
				ImageId = imageId
			};
			return this;
		}

		public IImageCardBuilder WithDescription(string description)
		{
			BuildingModel.Description = description;
			return this;
		}

		public IImageCardBuilder WithButton(Button button)
		{
			BuildingModel.Button = button;
			return this;
		}

		public IImageCardBuilder WithButton(Func<IButtonBuilder<Button>, Button> buttonBuildFunc,
			IButtonBuilder<Button> builder = null)
		{
			builder = builder ?? _defaultButtonBuilder;
			BuildingModel.Button = buttonBuildFunc(builder);
			return this;
		}
	}
}