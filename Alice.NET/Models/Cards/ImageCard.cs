using Alice.Models.Buttons;
using Alice.Models.Enums;
using Newtonsoft.Json;

namespace Alice.Models.Cards
{
	/// <summary>
	/// Одно изображение
	/// </summary>
	public class ImageCard : Card
	{
		public ImageCard(bool isBigImageCard) : base(isBigImageCard ? 
													(CardType?)CardType.BigImage : null)
		{ }

		public bool IsBigImageCard => Type == CardType.BigImage;

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