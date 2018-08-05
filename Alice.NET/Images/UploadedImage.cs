using Newtonsoft.Json;

namespace Alice.Images
{
	public class UploadedImage
	{
		/// <summary>
		/// Идентификатор изображения
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// URL изображения
		/// </summary>
		[JsonProperty("origUrl")]
		public string OriginalUrl { get; set; }
	}
}