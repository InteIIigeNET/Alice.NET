using Alice.Models.Buttons;

namespace Alice.Models.Builders.Buttons
{
	public class TipButtonBuilder : ButtonBuilder<TipButton>
	{
		public TipButtonBuilder Hide()
		{
			Button.Hide = true;
			return this;
		}
	}
}