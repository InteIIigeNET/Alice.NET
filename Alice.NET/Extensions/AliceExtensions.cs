using Alice.Models;

namespace Alice.Extensions
{
	public static class AliceExtensions
	{
        public static Models.AliceResponse Reply(this AliceRequest request,
            string text,
            bool endSession = false,
            Button[] buttons = null)
            => new Models.AliceResponse
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