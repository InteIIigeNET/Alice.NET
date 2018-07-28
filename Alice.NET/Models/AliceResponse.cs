using Newtonsoft.Json;

namespace Alice.Models
{
	/// <summary>
	/// Ответ на AliceRequest
	/// </summary>
	public class AliceResponse
	{
		/// <summary>
		/// Данные для ответа пользователю
		/// </summary>
		[JsonProperty("response")]
		public Response Response { get; set; }

		/// <summary>
		/// Данные о сессии
		/// </summary>
		[JsonProperty("session")]
		public Session Session { get; set; }

		/// <summary>
		/// Версия протокола
		/// </summary>
		[JsonProperty("version")]
		public string Version { get; set; } = AliceServiceConstants.ProtocolVersion;
	}
}