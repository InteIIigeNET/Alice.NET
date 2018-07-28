﻿using Newtonsoft.Json;

namespace Alice.Models
{
	/// Кнопки, которые следует показать пользователю.
	/// Все указанные кнопки выводятся после основного ответа Алисы, 
	/// описанного в свойствах response.text и response.card.
	/// Кнопки можно использовать как релевантные ответу ссылки или подсказки для продолжения разговора
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
		/// Произвольный JSON, который Яндекс.Диалоги должны отправить обработчику, 
		/// если данная кнопка будет нажата. Максимум 4096 байт
		/// </summary>		
		[JsonProperty("payload")]
		public object Payload { get; set; }

		/// <summary>
		/// URL, который должна открывать кнопка, максимум 1024 байта.
		/// Если свойство url не указано, по нажатию кнопки навыку будет отправлен текст кнопки
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }

		/// <summary>
		/// Признак того, что кнопку нужно убрать после следующей реплики пользователя. 
		/// Допустимые значения:
		/// false — кнопка должна оставаться активной (значение по умолчанию)
		/// true — кнопку нужно скрывать после нажатия
		/// </summary>
		[JsonProperty("hide")]
		public bool Hide { get; set; }
	}
}