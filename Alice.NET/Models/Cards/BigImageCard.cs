using Alice.Models.Buttons;
using Newtonsoft.Json;

namespace Alice.Models.Cards
{
	/// <summary>
	/// Одно изображение
	/// </summary>
	public class BigImageCard : Card
	{
		public BigImageCard() : base(CardType.BigImage)
		{ }

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