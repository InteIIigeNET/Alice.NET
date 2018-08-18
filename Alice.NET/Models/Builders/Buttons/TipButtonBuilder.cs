using Alice.Models.Buttons;

namespace Alice.Models.Builders.Buttons
{
	public class TipButtonBuilder : ButtonBuilder<TipButton>, ITipButtonBuilder
	{
		public ITipButtonBuilder Hide()
		{
			BuildingModel.Hide = true;
			return this;
		}
	}
}