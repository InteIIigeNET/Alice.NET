using Alice.Models.Buttons;

namespace Alice.Models.Builders.Buttons
{
	public class ButtonBuilder<TButton> : IButtonBuilder<TButton>
		where TButton : Button, new()
	{
		protected TButton Button;

		public IButtonBuilder<TButton> Create(string title)
		{
			Button = new TButton() {Title = title};
			return this;
		}

		public IButtonBuilder<TButton> WithUrl(string url)
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