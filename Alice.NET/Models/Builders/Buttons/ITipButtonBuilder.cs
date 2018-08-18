using Alice.Models.Buttons;

namespace Alice.Models.Builders.Buttons
{
	public interface ITipButtonBuilder : IButtonBuilder<TipButton>
	{
		ITipButtonBuilder Hide();
	}
}