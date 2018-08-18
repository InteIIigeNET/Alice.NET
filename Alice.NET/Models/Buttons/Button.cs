using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Alice.Models.Buttons
{
	public class Button
	{
		/// <summary>
		/// Текст кнопки, обязателен для каждой кнопки. Максимум 64 символа.
		/// Если для кнопки не указано свойство url, 
		/// по нажатию текст кнопки будет отправлен навыку как реплика пользователя
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// URL, который должна открывать кнопка, максимум 1024 байта.
		/// Если свойство url не указано, по нажатию кнопки навыку будет отправлен текст кнопки
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }

		/// <summary>
		/// Произвольный JSON, который Яндекс.Диалоги должны отправить обработчику, 
		/// если данная кнопка будет нажата. Максимум 4096 байт
		/// </summary>		
		[JsonProperty("payload")]
		public JObject Payload { get; set; } = JObject.Parse("");
	}
}   