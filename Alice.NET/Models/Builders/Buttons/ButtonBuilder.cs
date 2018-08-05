using Alice.Models.Buttons;

namespace Alice.Models.Builders.Buttons
{
	public class ButtonBuilder<TButton>
		where TButton : Button, new()
	{
		protected TButton Button;

		public ButtonBuilder<TButton> Create(string title)
		{
			Button = new TButton() {Title = title};
			return this;
		}

		public ButtonBuilder<TButton> WithUrl(string url)
		{
			Button.Url = url;
			return this;
		}

		public TButton Build()
		{
			return Button;
		}
	}
}