using System;
using Alice.Models.Builders.Cards;
using Alice.Models.Buttons;
using Alice.Models.Cards;
using Alice.Models.Enums;
using Alice.Models.Responses;

namespace Alice.Models.Builders.Responses
{
	public class ResponseBuilder : IResponseBuilder
	{
		private Response _response;
		private readonly IBigImageCardBuilder _defaultImageCardBuilder;
		private readonly IItemsListCardBuilder _defaultItemsListCardBuilder;

		public IResponseBuilder Create(string text) //возможно, тут придётся добавить bool useDefaultTts
		{
			_response = new Response {Text = text};
			return this;
		}

		public IResponseBuilder WithTts(string tts) 
		{
			_response.Tts = tts;
			return this;
		}

		public IResponseBuilder WithCard<TCard>(TCard card)
			where TCard : Card
		{
			card.Type = card.Type ?? CardType.BigImage;
			_response.Card = card;
			return this;
		}

		public IResponseBuilder WithBigImageCard(ImageCard card)
		{
			card.Type = CardType.BigImage;
			return WithCard(card);
		}

		public IResponseBuilder WithBigImageCard(Func<IBigImageCardBuilder, ImageCard> cardBuildFunc, 
												 IBigImageCardBuilder builder = null)
		{
			builder = builder ?? _defaultImageCardBuilder;
			_response.Card = cardBuildFunc(builder);
			return this;
		}

		public IResponseBuilder WithItemsListCard(ItemsListCard card)
		{
			return WithCard(card);
		}

		public IResponseBuilder WithItemsListCard(Func<IItemsListCardBuilder, ItemsListCard> cardBuildFunc,
			IItemsListCardBuilder builder)
		{
			builder = builder ?? _defaultItemsListCardBuilder;
			_response.Card = cardBuildFunc(builder);
			return this;
		}

		public IResponseBuilder WithButtons(params TipButton[] buttons)
		{
			_response.Buttons = buttons;
			return this;
		}

		public IResponseBuilder EndSession()
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