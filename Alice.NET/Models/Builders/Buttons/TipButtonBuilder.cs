using Alice.Models.Buttons;

namespace Alice.Models.Builders.Buttons
{
	public class TipButtonBuilder : ButtonBuilder<TipButton>
	{
		public ButtonBuilder<TipButton> Hide()
		{
			Button.Hide = true;
			return this;
		}
	}
}