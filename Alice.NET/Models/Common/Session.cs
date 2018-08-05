using Newtonsoft.Json;

namespace Alice.Models.Common
{
	/// <summary>
	/// Данные о сессии
	/// </summary>
	public class Session
	{
		/// <summary>
		/// Признак новой сессии. Возможные значения:
		/// true — пользователь начал новый разговор с навыком
		/// false — запрос отправлен в рамках уже начатого разговора
		/// </summary>
		[JsonProperty("new")]
		public bool New { get; set; }

		/// <summary>
		/// Идентификатор сообщения в рамках сессии, максимум 8 символов.
		/// Инкрементируется с каждым следующим запросом
		/// </summary>
		[JsonProperty("message_id")]
		public int MessageId { get; set; }

		/// <summary>
		/// Уникальный идентификатор сессии, максимум 64 символов
		/// </summary>
		[JsonProperty("session_id")]
		public string SessionId { get; set; }

		/// <summary>
		/// Идентификатор вызываемого навыка, присвоенный при создании.
		/// Чтобы узнать идентификатор своего навыка, 
		/// откройте его в личном кабинете — идентификатор будет в адресе страницы, 
		/// https://.../developer/skills/идентификатор/
		/// </summary>
		[JsonProperty("skill_id")]
		public string SkillId { get; set; }

		/// <summary>
		/// Идентификатор экземпляра приложения, 
		/// в котором пользователь общается с Алисой, максимум 64 символа
		/// Замечание: 
		/// Даже если пользователь авторизован с одним и тем же аккаунтом в приложении Яндекс для Android и iOS, 
		/// Яндекс.Диалоги присвоят отдельный user_id каждому из этих приложений
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}