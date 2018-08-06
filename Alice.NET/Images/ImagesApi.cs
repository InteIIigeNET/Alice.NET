using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Alice.JsonSerializer;

namespace Alice.Images
{
	public class ImagesApi
	{
		private readonly string _token;
		private readonly string _apiUrl;
		private readonly IJsonSerializer _jsonSerializer = new JsonSerializer.JsonSerializer(); //чёт не нравится такая интеграция зависимостей

		private static readonly HttpClient Client = new HttpClient()
		{
			DefaultRequestHeaders = {{"Host", "https://dialogs.yandex.net"}}
		};

		public ImagesApi(string skillId, string token)
		{
			_token = token;
			_apiUrl = $"https://dialogs.yandex.net/api/v1/skills/{skillId}/images";
		}

		private async Task<UploadedImage> TryUploadImage(HttpContent content)
		{
			content.Headers.Add("Authorization", $"OAuth {_token}");
			var response = await Client.PostAsync(_apiUrl, content);
			var responseString = await response.Content.ReadAsStringAsync();
			var result = _jsonSerializer.Deserialize<UploadedImage>(responseString);
			return result;
		}

		public async Task<UploadedImage> TryUploadImageFromUrlAsync(string url)
		{
			var uploadValues = new Dictionary<string, string>
			{
				{ "url", url }
			};
			var content = new FormUrlEncodedContent(uploadValues);
			content.Headers.Add("Content-Type", "application/json");

			return await TryUploadImage(content);
		}

		public async Task<UploadedImage> TryUploadImageFromFileAsync(string filename)
		{
			var imageBytes = File.ReadAllBytes(filename);
			var content = new ByteArrayContent(imageBytes);
			content.Headers.Add("Content-Type", "multipart/form-data");

			return await TryUploadImage(content);
		}

		public async Task<UploadedImage[]> TryGetUploadedImages()
		{
			var response = await Client.GetAsync(_apiUrl);
			var responseString = await response.Content.ReadAsStringAsync();
			var result = _jsonSerializer.Deserialize<UploadedImage[]>(responseString);
			return result;
		}
	}
}