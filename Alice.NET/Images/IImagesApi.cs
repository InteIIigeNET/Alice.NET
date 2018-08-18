using System.Threading.Tasks;

namespace Alice.Images
{
	public interface IImagesApi
	{
		Task<UploadedImage[]> TryGetUploadedImagesAsync();
		Task<UploadedImage> TryUploadImageFromFileAsync(string filename);
		Task<UploadedImage> TryUploadImageFromUrlAsync(string url);
	}
}