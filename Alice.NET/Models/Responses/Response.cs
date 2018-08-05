using Alice.Models.Buttons;
using Alice.Models.Cards;
using Newtonsoft.Json;

namespace Alice.Models.Responses
{
	/// <summary>
	/// Данные для ответа пользователю
	/// </summary>
	public class Response
	{
		/// <summary>
		/// Текст, который следует показать и сказать пользователю. 
		/// Максимум 1024 символа. Не должен быть пустым.
		/// Замечание:
		/// Текст также используется, если у Алисы не получилось отобразить включенную в ответ карточку(свойство response.card). 
		/// На устройствах, которые поддерживают только голосовое общение с навыком, 
		/// это будет происходить каждый раз, когда навык присылает карточку в ответе.
		/// В тексте ответа можно указать переводы строк последовательностью «\n», 
		/// например: "Отдых напрасен. Дорога крута.\nВечер прекрасен. Стучу в ворота."
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// Ответ в формате TTS (text-to-speech), максимум 1024 символа
		/// </summary>
		[JsonProperty("tts")]
		public string Tts { get; set; }

		/// <summary>
		/// Описание карточки — сообщения с поддержкой изображений.
		/// Если приложению удается отобразить карточку для пользователя, 
		/// свойство response.text не используется
		/// </summary>
		[JsonProperty("card")]
		public Card Card { get; set; }

		///<summary>
		/// Кнопки, которые следует показать пользователю.
		/// Все указанные кнопки выводятся после основного ответа Алисы, 
		/// описанного в свойствах response.text и response.card.
		/// Кнопки можно использовать как релевантные ответу ссылки или подсказки для продолжения разговора
		///</summary>
		[JsonProperty("buttons")]
		public TipButton[] Buttons { get; set; }

		/// <summary>
		/// Признак конца разговора:
		/// false — сессию следует продолжить
		/// true — сессию следует завершить
		/// </summary>
		[JsonProperty("end_session")]
		public bool EndSession { get; set; }
	}
}