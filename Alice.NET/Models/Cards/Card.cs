using Alice.Models.Enums;
using Newtonsoft.Json;

namespace Alice.Models.Cards
{
	public abstract class Card
	{
		protected Card(CardType? type)
		{
			Type = type;
		}

		/// <summary>
		/// Тип карточки. Поддерживаемые значения:
		/// BigImage — одно изображение.
		///	ItemsList — галерея изображений (от 1 до 5).
		/// Null — используется в качестве изображения внутри ItemsList
		/// </summary>
		[JsonProperty("type")]
		public CardType? Type { get; set; }
	}
}