using Alice.Models.Buttons;
using Alice.Models.Cards;
using Alice.Models.Responses;

namespace Alice.Models.Builders.Responses
{
	public class ResponseBuilder
	{
		private Response _response;

		public ResponseBuilder Create(string text)
		{
			_response = new Response {Text = text};
			return this;
		}

		public ResponseBuilder WithTts(string tts)
		{
			_response.Tts = tts;
			return this;
		}

		public ResponseBuilder WithCard<TCard>(TCard card)
			where TCard : Card
		{
			_response.Card = card;
			return this;
		}

		public ResponseBuilder WithButtons(params TipButton[] buttons)
		{
			_response.Buttons = buttons;
			return this;
		}

		public ResponseBuilder EndSession()
		{
			_response.EndSession = true;
			return this;
		}

		public Response Build()
		{
			return _response;
		}
	}
}