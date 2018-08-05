using Alice.Models.Common;
using Newtonsoft.Json;

namespace Alice.Models.Requests
{
	/// <summary>
	/// Запрос от Алисы
	/// </summary>
	public class AliceRequest
	{
		/// <summary>
		/// Информация об устройстве, с помощью которого пользователь разговаривает с Алисой
		/// </summary>
		[JsonProperty("meta")]
		public Meta Meta { get; set; }

		/// <summary>
		/// Данные, полученные от пользователя
		/// </summary>
		[JsonProperty("request")]
		public Request Request { get; set; }

		/// <summary>
		/// Данные о сессии
		/// </summary>
		[JsonProperty("session")]
		public Session Session { get; set; }

		/// <summary>
		/// Версия протокола
		/// </summary>
		[JsonProperty("version")]
		public string Version { get; set; }
	}
}