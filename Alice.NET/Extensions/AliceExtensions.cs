using Alice.Models;

namespace Alice.Extensions
{
	public static class AliceExtensions
	{
		public static AliceResponse Reply(this AliceRequest request,
			string text,
			bool endSession = false,
			Button[] buttons = null)
			=> new AliceResponse
			{
				Response = new Response
				{
					Text = text,
					Tts = text,
					EndSession = endSession
				},
				Session = request.Session
			};
	}
}