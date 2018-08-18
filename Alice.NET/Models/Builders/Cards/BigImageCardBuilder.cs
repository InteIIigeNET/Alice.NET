using Alice.Models.Cards;

namespace Alice.Models.Builders.Cards
{
	public interface IBigImageCardBuilder : IImageCardBuilder
	{ }

	public class BigImageCardBuilder : ImageCardBuilder, IBigImageCardBuilder
	{
		public override IImageCardBuilder Create(string title, string imageId)
		{
			BuildingModel = new ImageCard(isBigImageCard: true)
			{
				Title = title,
				ImageId = imageId
			};
			return this;
		}
	}
}