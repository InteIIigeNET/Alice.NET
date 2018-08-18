using Alice.Models.Buttons;

namespace Alice.Models.Builders.Buttons
{
	public class ButtonBuilder<TButton> : BaseBuilder<TButton>, IButtonBuilder<TButton>
		where TButton : Button, new()
	{
		public IButtonBuilder<TButton> Create(string title)
		{
			BuildingModel = new TButton() {Title = title};
			return this;
		}

		public IButtonBuilder<TButton> WithUrl(string url)
		{
			BuildingModel.Url = url;
			return this;
		}
	}
}