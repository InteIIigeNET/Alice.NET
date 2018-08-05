using Alice.Models.Buttons;
using Newtonsoft.Json;

namespace Alice.Models.Cards
{
	/// <summary>
	/// Кнопки под галереей изображений
	/// </summary>
	public class Footer
	{
		/// <summary>
		/// Текст первой кнопки, обязательное свойство. Максимум 64 символа
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }
		/// <summary>
		/// Дополнительная кнопка для галереи изображений.
		/// </summary>
		[JsonProperty("button")]
		public Button Button { get; set; }
	}
}