using Alice.Models.Buttons;
using Newtonsoft.Json;

namespace Alice.Models.Cards
{
	/// <summary>
	/// Набор изображений для галереи — не меньше 1, не больше 5
	/// </summary>
	public class CardItem
	{
		/// <summary>
		/// Идентификатор изображения, который возвращается в ответ на запрос загрузки
		/// </summary>
		[JsonProperty("image_id")]
		public string ImageId { get; set; }
		/// <summary>
		/// Заголовок для изображения
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
		/// <summary>
		/// Описание изображения
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }
		/// <summary>
		/// Свойства изображения, на которое можно нажать
		/// </summary>
		[JsonProperty("button")]
		public Button Button { get; set; }
	}
}