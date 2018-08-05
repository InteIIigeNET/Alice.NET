using Newtonsoft.Json;

namespace Alice.Models.Requests
{
	/// <summary>
	/// Информация об устройстве, с помощью которого пользователь разговаривает с Алисой
	/// </summary>
	public class Meta
	{
		/// <summary>
		/// Язык в POSIX-формате, максимум 64 символа
		/// </summary>
		[JsonProperty("locale")]
		public string Locale { get; set; }

		/// <summary>
		/// Название часового пояса, включая алиасы, максимум 64 символа
		/// </summary>
		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		/// <summary>
		/// Идентификатор устройства и приложения, в котором идет разговор, максимум 1024 символа
		/// </summary>
		[JsonProperty("client_id")]
		public string ClientId { get; set; }
	}
}