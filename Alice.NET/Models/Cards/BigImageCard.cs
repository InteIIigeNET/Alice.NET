using Alice.Models.Buttons;

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
		public string ImageId { get; set; }

		/// <summary>
		/// Заголовок для изображения
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Описание изображения
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Свойства изображения, на которое можно нажать
		/// </summary>
		public Button Button { get; set; }
	}
}