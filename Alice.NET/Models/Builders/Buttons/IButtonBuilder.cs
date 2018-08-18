using Alice.Models.Buttons;

namespace Alice.Models.Builders.Buttons
{
	public interface IButtonBuilder<out TButton> : IModelBuilder<TButton> 
		where TButton : Button, new()
	{
		IButtonBuilder<TButton> Create(string title);
		IButtonBuilder<TButton> WithUrl(string url);
	}
}