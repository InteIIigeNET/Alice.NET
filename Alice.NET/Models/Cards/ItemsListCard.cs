using Newtonsoft.Json;

namespace Alice.Models.Cards
{
	/// <summary>
	/// Галерея изображений
	/// </summary>
	public class ItemsListCard : Card
	{
		public ItemsListCard() : base(CardType.ItemsList)
		{ }

		/// <summary>
		/// Заголовок галереи изображений
		/// </summary>
		[JsonProperty("header")]
		public Header Header { get; set; }
		/// <summary>
		/// Набор изображений для галереи — не меньше 1, не больше 5
		/// </summary>
		[JsonProperty("items")]
		public CardItem[] CardItems { get; set; }
		/// <summary>
		/// Кнопки под галереей изображений
		/// </summary>
		[JsonProperty("footer")]
		public Footer Footer { get; set; }
	}
}