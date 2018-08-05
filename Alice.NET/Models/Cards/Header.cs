using Newtonsoft.Json;

namespace Alice.Models.Cards
{
	/// <summary>
	/// Заголовок галереи изображений
	/// </summary>
	public class Header
	{
		/// <summary>
		/// Текст заголовка, обязателен, если передается свойство header. Максимум 64 символа
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }
	}
}