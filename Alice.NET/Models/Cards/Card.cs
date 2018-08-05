using Newtonsoft.Json;

namespace Alice.Models.Cards
{
	/// <summary>
	/// Тип карточки
	/// </summary>
	public enum CardType
	{
		/// <summary>
		/// Одно изображение
		/// </summary>
		BigImage,
		/// <summary>
		/// Галерея изображений
		/// </summary>
		ItemsList
	}

	public abstract class Card
	{
		protected Card(CardType type)
		{
			Type = type;
		}

		/// <summary>
		/// Тип карточки. Поддерживаемые значения:
		/// BigImage — одно изображение.
		///	ItemsList — галерея изображений (от 1 до 5).
		/// </summary>
		[JsonProperty("type")]
		public CardType Type { get; set; }
	}
}