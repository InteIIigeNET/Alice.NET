using Alice.Models.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alice.Models.Requests
{
	/// <summary>
	/// Данные, полученные от пользователя
	/// </summary>
	public class Request
	{
		/// <summary>
		/// Запрос, который был передан вместе с командой активации навыка
		/// </summary>
		[JsonProperty("command")]
		public string Command { get; set; }

		/// <summary>
		/// Полный текст пользовательского запроса, максимум 1024 символа
		/// </summary>
		[JsonProperty("original_utterance")]
		public string OriginalUtterance { get; set; }

		/// <summary>
		/// Тип ввода
		/// </summary>
		[JsonProperty("type")]
		public RequestType Type { get; set; }

		/// <summary>
		/// Формальные характеристики реплики, 
		/// которые удалось выделить Яндекс.Диалогам.
		/// Отсутствует, если ни одно из вложенных свойств не применимо
		/// </summary>
		[JsonProperty("markup")]
		public Markup Markup { get; set; }

		/// <summary>
		/// JSON, полученный с нажатой кнопкой от обработчика навыка (в ответе на предыдущий запрос), 
		/// максимум 4096 байт
		/// </summary>
		[JsonProperty("payload")]
		public JObject Payload { get; set; }
	}
}